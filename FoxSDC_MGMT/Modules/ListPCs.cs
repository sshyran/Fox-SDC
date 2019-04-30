﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxSDC_Common;

namespace FoxSDC_MGMT
{
    public partial class ctlListPCs : UserControl
    {
        bool? Approved;
        Int64? Group;

        public ctlListPCs(bool? approved, Int64? group)
        {
            Approved = approved;
            Group = group;
            InitializeComponent();
        }

        void LoadList()
        {
            lstComputers.Items.Clear();
            List<ComputerData> cdlst = Program.net.GetComputerList(Approved, Group);
            if (cdlst == null)
                return;
            foreach (ComputerData cd in cdlst)
            {
                ListViewItem lst = new ListViewItem(cd.Computername);
                lst.Tag = cd;
                lst.ImageIndex = 2;
                lst.SubItems.Add(cd.GroupingPath);
                lst.SubItems.Add(cd.Comments);
                lst.SubItems.Add(cd.Approved == true ? "Approved" : "Not approved");
                lst.SubItems.Add(cd.OS);
                lst.SubItems.Add(cd.OSVersion);
                lst.SubItems.Add(cd.Is64Bit == true ? "64 bit" : "32 bit");
                lst.SubItems.Add(cd.OSSuite);
                lst.SubItems.Add(cd.Language);
                lst.SubItems.Add(cd.Make);
                lst.SubItems.Add(cd.LastUpdated.ToLongDateString() + " " + cd.LastUpdated.ToLongTimeString());
                lst.SubItems.Add(cd.ContractID);
                lst.SubItems.Add(cd.AgentVersion);
                lstComputers.Items.Add(lst);
            }
        }

        private void ctlUnapprovedPCs_Load(object sender, EventArgs e)
        {
            Program.LoadImageList(imageList1);
            LoadList();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstComputers.SelectedItems.Count == 0)
                return;
            ComputerData cd = (ComputerData)lstComputers.SelectedItems[0].Tag;
            frmComputerInfo pci = new frmComputerInfo(cd.MachineID);
            pci.Show();
        }

        private void lstComputers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                propertiesToolStripMenuItem_Click(sender, e);
        }

        private void approveRefuseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstComputers.SelectedItems.Count == 0)
                return;

            List<ApproveListElement> ll = new List<ApproveListElement>();

            foreach (ListViewItem l in lstComputers.SelectedItems)
            {
                ComputerData cd = (ComputerData)l.Tag;
                ApproveListElement a = new ApproveListElement();
                a.Computername = cd.Computername;
                a.MachineID = cd.MachineID;
                ll.Add(a);
            }
            frmApproveRefusePC frm = new frmApproveRefusePC(ll);
            if (frm.ShowDialog(this) == DialogResult.OK)
                LoadList();
        }

        private void lstComputers_DoubleClick(object sender, EventArgs e)
        {
            propertiesToolStripMenuItem_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstComputers.SelectedItems.Count == 0)
                return;
            foreach (ListViewItem l in lstComputers.SelectedItems)
            {
                ComputerData cd = (ComputerData)l.Tag;
                DialogResult res = MessageBox.Show(this, "Do you really want to delete the computer " + cd.Computername + "?", Program.Title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Cancel)
                    return;
                if (res == DialogResult.No)
                    continue;
                if (Program.net.DeleteComputer(cd.MachineID) == false)
                {
                    if (MessageBox.Show(this, "Delete of computer " + cd.Computername + " failed: " + Program.net.GetLastError(), Program.Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.Cancel)
                        return;
                }
            }
            LoadList();
        }

        private void setcommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstComputers.SelectedItems.Count != 1)
                return;
            foreach (ListViewItem l in lstComputers.SelectedItems)
            {
                ComputerData cd = (ComputerData)l.Tag;
                frmAskText txt = new frmAskText("Change comment", "Change comment on computer " + cd.Computername, cd.Comments);
                if (txt.ShowDialog(this) != DialogResult.OK)
                    return;
                Program.net.ChangeComputerComment(cd.MachineID, txt.RetText);
            }
            LoadList();
        }

        private void connectToScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstComputers.SelectedItems.Count == 0)
                return;
            foreach (ListViewItem l in lstComputers.SelectedItems)
            {
                ComputerData cd = (ComputerData)l.Tag;
                if (cd.Approved == true)
                    Utilities.ConnectToScreen(this, cd.MachineID);
            }
        }
    }
}