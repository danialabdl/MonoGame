﻿// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using Eto.Forms;

namespace MonoGame.Tools.Pipeline
{
    public partial class BuildOutput : Panel
    {
        TextArea textArea;

        Xwt.TreeView treeView;

        private void InitializeComponent()
        {
            textArea = new TextArea();
            textArea.Wrap = false;
            textArea.ReadOnly = true;

            treeView = new Xwt.TreeView();
            treeView.HeadersVisible = false;

            Content = textArea;
        }
    }
}

