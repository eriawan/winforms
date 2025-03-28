﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms.TestUtilities;
using Microsoft.DotNet.RemoteExecutor;
using Moq;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace System.Windows.Forms.Tests;

public class TabPageTests
{
    [WinFormsFact]
    public void TabPage_Ctor_Default()
    {
        using SubTabPage control = new();
        Assert.Null(control.AccessibleDefaultActionDescription);
        Assert.Null(control.AccessibleDescription);
        Assert.Null(control.AccessibleName);
        Assert.Equal(AccessibleRole.Default, control.AccessibleRole);
        Assert.False(control.AllowDrop);
        Assert.Equal(AnchorStyles.Top | AnchorStyles.Left, control.Anchor);
        Assert.False(control.AutoScroll);
        Assert.Equal(Size.Empty, control.AutoScrollMargin);
        Assert.Equal(Size.Empty, control.AutoScrollMinSize);
        Assert.Equal(Point.Empty, control.AutoScrollPosition);
        Assert.False(control.AutoSize);
        Assert.Equal(AutoSizeMode.GrowOnly, control.AutoSizeMode);
        Assert.Equal(Control.DefaultBackColor, control.BackColor);
        Assert.Null(control.BackgroundImage);
        Assert.Equal(ImageLayout.Tile, control.BackgroundImageLayout);
        Assert.Null(control.BindingContext);
        Assert.Equal(BorderStyle.None, control.BorderStyle);
        Assert.Equal(100, control.Bottom);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.Bounds);
        Assert.True(control.CanEnableIme);
        Assert.False(control.CanFocus);
        Assert.True(control.CanRaiseEvents);
        Assert.False(control.CanSelect);
        Assert.False(control.Capture);
        Assert.True(control.CausesValidation);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.ClientRectangle);
        Assert.Equal(new Size(200, 100), control.ClientSize);
        Assert.Null(control.Container);
        Assert.False(control.ContainsFocus);
        Assert.True(control.CausesValidation);
        Assert.Empty(control.Controls);
        Assert.Same(control.Controls, control.Controls);
        Assert.IsType<TabPage.TabPageControlCollection>(control.Controls);
        Assert.False(control.Created);
        Assert.Same(Cursors.Default, control.Cursor);
        Assert.Same(Cursors.Default, control.DefaultCursor);
        Assert.Equal(ImeMode.Inherit, control.DefaultImeMode);
        Assert.Equal(new Padding(3), control.DefaultMargin);
        Assert.Equal(Size.Empty, control.DefaultMaximumSize);
        Assert.Equal(Size.Empty, control.DefaultMinimumSize);
        Assert.Equal(Padding.Empty, control.DefaultPadding);
        Assert.Equal(new Size(200, 100), control.DefaultSize);
        Assert.False(control.DesignMode);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.DisplayRectangle);
        Assert.Equal(DockStyle.None, control.Dock);
        Assert.NotNull(control.DockPadding);
        Assert.Same(control.DockPadding, control.DockPadding);
        Assert.Equal(0, control.DockPadding.Top);
        Assert.Equal(0, control.DockPadding.Bottom);
        Assert.Equal(0, control.DockPadding.Left);
        Assert.Equal(0, control.DockPadding.Right);
        Assert.False(control.DoubleBuffered);
        Assert.True(control.Enabled);
        Assert.NotNull(control.Events);
        Assert.Same(control.Events, control.Events);
        Assert.False(control.Focused);
        Assert.Equal(Control.DefaultFont, control.Font);
        Assert.Equal(control.Font.Height, control.FontHeight);
        Assert.Equal(Control.DefaultForeColor, control.ForeColor);
        Assert.False(control.HasChildren);
        Assert.Equal(100, control.Height);
        Assert.NotNull(control.HorizontalScroll);
        Assert.Same(control.HorizontalScroll, control.HorizontalScroll);
        Assert.False(control.HScroll);
        Assert.Equal(ImeMode.NoControl, control.ImeMode);
        Assert.Equal(ImeMode.NoControl, control.ImeModeBase);
        Assert.False(control.IsAccessible);
        Assert.False(control.IsMirrored);
        Assert.NotNull(control.LayoutEngine);
        Assert.Same(control.LayoutEngine, control.LayoutEngine);
        Assert.Equal(0, control.Left);
        Assert.Equal(Point.Empty, control.Location);
        Assert.Equal(new Padding(3), control.Margin);
        Assert.Equal(Size.Empty, control.MaximumSize);
        Assert.Equal(Size.Empty, control.MinimumSize);
        Assert.Equal(Padding.Empty, control.Padding);
        Assert.Null(control.Parent);
        Assert.Equal(Size.Empty, control.PreferredSize);
        Assert.Equal("Microsoft\u00AE .NET", control.ProductName);
        Assert.False(control.RecreatingHandle);
        Assert.Null(control.Region);
        Assert.False(control.ResizeRedraw);
        Assert.Equal(200, control.Right);
        Assert.Equal(RightToLeft.No, control.RightToLeft);
        Assert.True(control.ShowFocusCues);
        Assert.True(control.ShowKeyboardCues);
        Assert.Null(control.Site);
        Assert.Equal(new Size(200, 100), control.Size);
        Assert.Equal(0, control.TabIndex);
        Assert.False(control.TabStop);
        Assert.Empty(control.Text);
        Assert.Equal(0, control.Top);
        Assert.Null(control.TopLevelControl);
        Assert.False(control.UseVisualStyleBackColor);
        Assert.False(control.UseWaitCursor);
        Assert.True(control.Visible);
        Assert.NotNull(control.VerticalScroll);
        Assert.Same(control.VerticalScroll, control.VerticalScroll);
        Assert.False(control.VScroll);
        Assert.Equal(200, control.Width);

        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [NormalizedStringData]
    public void TabPage_Ctor_String(string text, string expectedText)
    {
        using SubTabPage control = new(text);
        Assert.Null(control.AccessibleDefaultActionDescription);
        Assert.Null(control.AccessibleDescription);
        Assert.Null(control.AccessibleName);
        Assert.Equal(AccessibleRole.Default, control.AccessibleRole);
        Assert.False(control.AllowDrop);
        Assert.Equal(AnchorStyles.Top | AnchorStyles.Left, control.Anchor);
        Assert.False(control.AutoScroll);
        Assert.Equal(Size.Empty, control.AutoScrollMargin);
        Assert.Equal(Size.Empty, control.AutoScrollMinSize);
        Assert.Equal(Point.Empty, control.AutoScrollPosition);
        Assert.False(control.AutoSize);
        Assert.Equal(AutoSizeMode.GrowOnly, control.AutoSizeMode);
        Assert.Equal(Control.DefaultBackColor, control.BackColor);
        Assert.Null(control.BackgroundImage);
        Assert.Equal(ImageLayout.Tile, control.BackgroundImageLayout);
        Assert.Null(control.BindingContext);
        Assert.Equal(BorderStyle.None, control.BorderStyle);
        Assert.Equal(100, control.Bottom);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.Bounds);
        Assert.True(control.CanEnableIme);
        Assert.False(control.CanFocus);
        Assert.True(control.CanRaiseEvents);
        Assert.False(control.CanSelect);
        Assert.False(control.Capture);
        Assert.True(control.CausesValidation);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.ClientRectangle);
        Assert.Equal(new Size(200, 100), control.ClientSize);
        Assert.Null(control.Container);
        Assert.False(control.ContainsFocus);
        Assert.True(control.CausesValidation);
        Assert.Empty(control.Controls);
        Assert.Same(control.Controls, control.Controls);
        Assert.IsType<TabPage.TabPageControlCollection>(control.Controls);
        Assert.False(control.Created);
        Assert.Same(Cursors.Default, control.Cursor);
        Assert.Same(Cursors.Default, control.DefaultCursor);
        Assert.Equal(ImeMode.Inherit, control.DefaultImeMode);
        Assert.Equal(new Padding(3), control.DefaultMargin);
        Assert.Equal(Size.Empty, control.DefaultMaximumSize);
        Assert.Equal(Size.Empty, control.DefaultMinimumSize);
        Assert.Equal(Padding.Empty, control.DefaultPadding);
        Assert.Equal(new Size(200, 100), control.DefaultSize);
        Assert.False(control.DesignMode);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.DisplayRectangle);
        Assert.Equal(DockStyle.None, control.Dock);
        Assert.NotNull(control.DockPadding);
        Assert.Same(control.DockPadding, control.DockPadding);
        Assert.Equal(0, control.DockPadding.Top);
        Assert.Equal(0, control.DockPadding.Bottom);
        Assert.Equal(0, control.DockPadding.Left);
        Assert.Equal(0, control.DockPadding.Right);
        Assert.False(control.DoubleBuffered);
        Assert.True(control.Enabled);
        Assert.NotNull(control.Events);
        Assert.Same(control.Events, control.Events);
        Assert.False(control.Focused);
        Assert.Equal(Control.DefaultFont, control.Font);
        Assert.Equal(control.Font.Height, control.FontHeight);
        Assert.Equal(Control.DefaultForeColor, control.ForeColor);
        Assert.False(control.HasChildren);
        Assert.Equal(100, control.Height);
        Assert.NotNull(control.HorizontalScroll);
        Assert.Same(control.HorizontalScroll, control.HorizontalScroll);
        Assert.False(control.HScroll);
        Assert.Equal(ImeMode.NoControl, control.ImeMode);
        Assert.Equal(ImeMode.NoControl, control.ImeModeBase);
        Assert.False(control.IsAccessible);
        Assert.False(control.IsMirrored);
        Assert.NotNull(control.LayoutEngine);
        Assert.Same(control.LayoutEngine, control.LayoutEngine);
        Assert.Equal(0, control.Left);
        Assert.Equal(Point.Empty, control.Location);
        Assert.Equal(new Padding(3), control.Margin);
        Assert.Equal(Size.Empty, control.MaximumSize);
        Assert.Equal(Size.Empty, control.MinimumSize);
        Assert.Equal(Padding.Empty, control.Padding);
        Assert.Null(control.Parent);
        Assert.Equal(Size.Empty, control.PreferredSize);
        Assert.Equal("Microsoft\u00AE .NET", control.ProductName);
        Assert.False(control.RecreatingHandle);
        Assert.Null(control.Region);
        Assert.False(control.ResizeRedraw);
        Assert.Equal(200, control.Right);
        Assert.Equal(RightToLeft.No, control.RightToLeft);
        Assert.True(control.ShowFocusCues);
        Assert.True(control.ShowKeyboardCues);
        Assert.Null(control.Site);
        Assert.Equal(new Size(200, 100), control.Size);
        Assert.Equal(0, control.TabIndex);
        Assert.False(control.TabStop);
        Assert.Equal(expectedText, control.Text);
        Assert.Equal(0, control.Top);
        Assert.Null(control.TopLevelControl);
        Assert.False(control.UseVisualStyleBackColor);
        Assert.False(control.UseWaitCursor);
        Assert.True(control.Visible);
        Assert.NotNull(control.VerticalScroll);
        Assert.Same(control.VerticalScroll, control.VerticalScroll);
        Assert.False(control.VScroll);
        Assert.Equal(200, control.Width);

        Assert.False(control.IsHandleCreated);
    }

    [WinFormsFact]
    public void TabPage_CreateParams_GetDefault_ReturnsExpected()
    {
        using SubTabPage control = new();
        CreateParams createParams = control.CreateParams;
        Assert.Null(createParams.Caption);
        Assert.Null(createParams.ClassName);
        Assert.Equal(0x8, createParams.ClassStyle);
        Assert.Equal(0x10000, createParams.ExStyle);
        Assert.Equal(100, createParams.Height);
        Assert.Equal(IntPtr.Zero, createParams.Parent);
        Assert.Null(createParams.Param);
        Assert.Equal(0x56000000, createParams.Style);
        Assert.Equal(200, createParams.Width);
        Assert.Equal(0, createParams.X);
        Assert.Equal(0, createParams.Y);
        Assert.Same(createParams, control.CreateParams);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [MemberData(nameof(ControlTests.Anchor_Set_TestData), MemberType = typeof(ControlTests))]
    public void TabPage_Anchor_Set_GetReturnsExpected(AnchorStyles value, AnchorStyles expected)
    {
        using TabPage control = new()
        {
            Anchor = value
        };
        Assert.Equal(expected, control.Anchor);
        Assert.Equal(DockStyle.None, control.Dock);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.Anchor = value;
        Assert.Equal(expected, control.Anchor);
        Assert.Equal(DockStyle.None, control.Dock);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [MemberData(nameof(ControlTests.Anchor_Set_TestData), MemberType = typeof(ControlTests))]
    public void TabPage_Anchor_SetWithOldValue_GetReturnsExpected(AnchorStyles value, AnchorStyles expected)
    {
        using TabPage control = new()
        {
            Anchor = AnchorStyles.Left
        };

        control.Anchor = value;
        Assert.Equal(expected, control.Anchor);
        Assert.Equal(DockStyle.None, control.Dock);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.Anchor = value;
        Assert.Equal(expected, control.Anchor);
        Assert.Equal(DockStyle.None, control.Dock);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [MemberData(nameof(ControlTests.Anchor_SetWithDock_TestData), MemberType = typeof(ControlTests))]
    public void TabPage_Anchor_SetWithDock_GetReturnsExpected(DockStyle dock, AnchorStyles value, AnchorStyles expectedAnchor, DockStyle expectedDock)
    {
        using TabPage control = new()
        {
            Dock = dock
        };

        control.Anchor = value;
        Assert.Equal(expectedAnchor, control.Anchor);
        Assert.Equal(expectedDock, control.Dock);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.Anchor = value;
        Assert.Equal(expectedAnchor, control.Anchor);
        Assert.Equal(expectedDock, control.Dock);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [BoolData]
    public void TabPage_AutoSize_Set_GetReturnsExpected(bool value)
    {
        using TabPage control = new();
        int layoutCallCount = 0;
        control.Layout += (sender, e) => layoutCallCount++;

        control.AutoSize = value;
        Assert.Equal(value, control.AutoSize);
        Assert.Equal(0, layoutCallCount);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.AutoSize = value;
        Assert.Equal(value, control.AutoSize);
        Assert.Equal(0, layoutCallCount);
        Assert.False(control.IsHandleCreated);

        // Set different.
        control.AutoSize = !value;
        Assert.Equal(!value, control.AutoSize);
        Assert.Equal(0, layoutCallCount);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsFact]
    public void TabPage_AutoSize_SetWithHandler_CallsAutoSizeChanged()
    {
        using TabPage control = new()
        {
            AutoSize = true
        };
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            callCount++;
        };
        control.AutoSizeChanged += handler;

        // Set different.
        control.AutoSize = false;
        Assert.False(control.AutoSize);
        Assert.Equal(1, callCount);

        // Set same.
        control.AutoSize = false;
        Assert.False(control.AutoSize);
        Assert.Equal(1, callCount);

        // Set different.
        control.AutoSize = true;
        Assert.True(control.AutoSize);
        Assert.Equal(2, callCount);

        // Remove handler.
        control.AutoSizeChanged -= handler;
        control.AutoSize = false;
        Assert.False(control.AutoSize);
        Assert.Equal(2, callCount);
    }

    [WinFormsTheory]
    [EnumData<AutoSizeMode>]
    [InvalidEnumData<AutoSizeMode>]
    public void TabPage_AutoSizeMode_Set_GetReturnsExpected(AutoSizeMode value)
    {
        using SubTabPage control = new();
        int layoutCallCount = 0;
        control.Layout += (sender, e) => layoutCallCount++;

        control.AutoSizeMode = value;
        Assert.Equal(AutoSizeMode.GrowOnly, control.AutoSizeMode);
        Assert.Equal(AutoSizeMode.GrowOnly, control.GetAutoSizeMode());
        Assert.False(control.IsHandleCreated);
        Assert.Equal(0, layoutCallCount);

        // Set same.
        control.AutoSizeMode = value;
        Assert.Equal(AutoSizeMode.GrowOnly, control.AutoSizeMode);
        Assert.Equal(AutoSizeMode.GrowOnly, control.GetAutoSizeMode());
        Assert.False(control.IsHandleCreated);
        Assert.Equal(0, layoutCallCount);
    }

    [WinFormsTheory]
    [EnumData<AutoSizeMode>]
    [InvalidEnumData<AutoSizeMode>]
    public void TabPage_AutoSizeMode_SetWithParent_GetReturnsExpected(AutoSizeMode value)
    {
        using TabControl parent = new();
        using SubTabPage control = new()
        {
            Parent = parent
        };
        int layoutCallCount = 0;
        control.Layout += (sender, e) => layoutCallCount++;
        int parentLayoutCallCount = 0;
        parent.Layout += (sender, e) => parentLayoutCallCount++;

        control.AutoSizeMode = value;
        Assert.Equal(AutoSizeMode.GrowOnly, control.AutoSizeMode);
        Assert.Equal(AutoSizeMode.GrowOnly, control.GetAutoSizeMode());
        Assert.False(control.IsHandleCreated);
        Assert.Equal(0, layoutCallCount);
        Assert.False(parent.IsHandleCreated);
        Assert.Equal(0, parentLayoutCallCount);

        // Set same.
        control.AutoSizeMode = value;
        Assert.Equal(AutoSizeMode.GrowOnly, control.AutoSizeMode);
        Assert.Equal(AutoSizeMode.GrowOnly, control.GetAutoSizeMode());
        Assert.False(control.IsHandleCreated);
        Assert.Equal(0, layoutCallCount);
        Assert.False(parent.IsHandleCreated);
        Assert.Equal(0, parentLayoutCallCount);
    }

    [WinFormsTheory]
    [EnumData<AutoSizeMode>]
    [InvalidEnumData<AutoSizeMode>]
    public void TabPage_AutoSizeMode_SetWithHandle_GetReturnsExpected(AutoSizeMode value)
    {
        using SubTabPage control = new();
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        control.AutoSizeMode = value;
        Assert.Equal(AutoSizeMode.GrowOnly, control.AutoSizeMode);
        Assert.Equal(AutoSizeMode.GrowOnly, control.GetAutoSizeMode());
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set same.
        control.AutoSizeMode = value;
        Assert.Equal(AutoSizeMode.GrowOnly, control.AutoSizeMode);
        Assert.Equal(AutoSizeMode.GrowOnly, control.GetAutoSizeMode());
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsTheory]
    [EnumData<AutoSizeMode>]
    [InvalidEnumData<AutoSizeMode>]
    public void TabPage_AutoSizeMode_SetWithHandleWithParent_GetReturnsExpected(AutoSizeMode value)
    {
        using TabControl parent = new();
        using SubTabPage control = new()
        {
            Parent = parent
        };
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int layoutCallCount = 0;
        control.Layout += (sender, e) => layoutCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;
        int parentLayoutCallCount = 0;
        parent.Layout += (sender, e) => parentLayoutCallCount++;

        control.AutoSizeMode = value;
        Assert.Equal(AutoSizeMode.GrowOnly, control.AutoSizeMode);
        Assert.Equal(AutoSizeMode.GrowOnly, control.GetAutoSizeMode());
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.Equal(0, layoutCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);
        Assert.Equal(0, parentLayoutCallCount);

        // Set same.
        control.AutoSizeMode = value;
        Assert.Equal(AutoSizeMode.GrowOnly, control.AutoSizeMode);
        Assert.Equal(AutoSizeMode.GrowOnly, control.GetAutoSizeMode());
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.Equal(0, layoutCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);
        Assert.Equal(0, parentLayoutCallCount);
    }

    [WinFormsTheory]
    [BoolData]
    public static void TabPage_BackColor_Get_ReturnsExpected(bool useVisualStyleBackColor)
    {
        using TabPage control = new()
        {
            UseVisualStyleBackColor = useVisualStyleBackColor
        };
        Assert.Equal(Control.DefaultBackColor, control.BackColor);
    }

    [WinFormsTheory(Skip = "Crash with AbandonedMutexException. See: https://github.com/dotnet/arcade/issues/5325")]
    [BoolData]
    public static void TabPage_BackColor_GetVisualStyles_ReturnsExpected(bool useVisualStyleBackColorParam)
    {
        // Run this from another thread as we call Application.EnableVisualStyles.
        RemoteExecutor.Invoke((useVisualStyleBackColorString) =>
        {
            bool useVisualStyleBackColor = bool.Parse(useVisualStyleBackColorString);

            Application.EnableVisualStyles();

            using TabPage control = new()
            {
                UseVisualStyleBackColor = useVisualStyleBackColor
            };
            Assert.Equal(Control.DefaultBackColor, control.BackColor);
        }, useVisualStyleBackColorParam.ToString()).Dispose();
    }

    [WinFormsTheory]
    [InlineData(true, TabAppearance.Buttons)]
    [InlineData(true, TabAppearance.FlatButtons)]
    // Has different behavior with VisualStyles on, see: TabPage_BackColor_TabAppearance_Normal_GetWithParent_ReturnsExpected
    // [InlineData(true, TabAppearance.Normal)]
    [InlineData(false, TabAppearance.Buttons)]
    [InlineData(false, TabAppearance.FlatButtons)]
    [InlineData(false, TabAppearance.Normal)]
    public static void TabPage_BackColor_GetWithParent_ReturnsExpected(bool useVisualStyleBackColor, TabAppearance parentAppearance)
    {
        if (Application.UseVisualStyles)
        {
            return;
        }

        using TabControl parent = new()
        {
            Appearance = parentAppearance
        };
        using TabPage control = new()
        {
            UseVisualStyleBackColor = useVisualStyleBackColor,
            Parent = parent
        };

        Assert.Equal(Control.DefaultBackColor, control.BackColor);
    }

    [WinFormsFact]
    public static void TabPage_BackColor_TabAppearance_Normal_GetWithParent_ReturnsExpected()
    {
        using TabControl parent = new()
        {
            Appearance = TabAppearance.Normal
        };
        using TabPage control = new()
        {
            UseVisualStyleBackColor = true,
            Parent = parent
        };

        if (Application.UseVisualStyles)
        {
            Assert.Equal(Color.Transparent, control.BackColor);
        }
        else
        {
            Assert.Equal(Control.DefaultBackColor, control.BackColor);
        }
    }

    public static IEnumerable<object[]> BackColor_GetVisualStylesWithParent_TestData()
    {
        yield return new object[] { true, TabAppearance.Buttons, Control.DefaultBackColor };
        yield return new object[] { true, TabAppearance.FlatButtons, Control.DefaultBackColor };
        yield return new object[] { true, TabAppearance.Normal, Color.Transparent };
        yield return new object[] { false, TabAppearance.Buttons, Control.DefaultBackColor };
        yield return new object[] { false, TabAppearance.FlatButtons, Control.DefaultBackColor };
        yield return new object[] { false, TabAppearance.Normal, Control.DefaultBackColor };
    }

    [WinFormsTheory(Skip = "Crash with AbandonedMutexException. See: https://github.com/dotnet/arcade/issues/5325")]
    [MemberData(nameof(BackColor_GetVisualStylesWithParent_TestData))]
    public static void TabPage_BackColor_GetVisualStylesWithParent_ReturnsExpected(bool useVisualStyleBackColorParam, TabAppearance parentAppearanceParam, Color expectedParam)
    {
        // Run this from another thread as we call Application.EnableVisualStyles.
        RemoteExecutor.Invoke((useVisualStyleBackColorString, parentAppearanceString, expectedString) =>
        {
            bool useVisualStyleBackColor = bool.Parse(useVisualStyleBackColorString);
            TabAppearance parentAppearance = (TabAppearance)Enum.Parse(typeof(TabAppearance), parentAppearanceString);
            Color expected = Color.FromArgb(int.Parse(expectedString));

            Application.EnableVisualStyles();

            using TabControl parent = new()
            {
                Appearance = parentAppearance
            };
            using TabPage control = new()
            {
                UseVisualStyleBackColor = useVisualStyleBackColor,
                Parent = parent
            };
            Assert.Equal(expected.ToArgb(), control.BackColor.ToArgb());
        }, useVisualStyleBackColorParam.ToString(), parentAppearanceParam.ToString(), expectedParam.ToArgb().ToString()).Dispose();
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(CommonTestHelperEx), nameof(CommonTestHelperEx.GetBackColorTheoryData))]
    public void TabPage_BackColor_Set_GetReturnsExpected(Color value, Color expected)
    {
        using TabPage control = new()
        {
            BackColor = value
        };
        Assert.Equal(expected, control.BackColor);
        Assert.False(control.UseVisualStyleBackColor);

        // Set same.
        control.BackColor = value;
        Assert.Equal(expected, control.BackColor);
        Assert.False(control.UseVisualStyleBackColor);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(CommonTestHelperEx), nameof(CommonTestHelperEx.GetBackColorTheoryData))]
    public void TabPage_BackColor_SetWithUseVisualStyleBackColor_GetReturnsExpected(Color value, Color expected)
    {
        using TabPage control = new()
        {
            UseVisualStyleBackColor = true,
            BackColor = value
        };
        Assert.Equal(expected, control.BackColor);
        Assert.False(control.UseVisualStyleBackColor);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.BackColor = value;
        Assert.Equal(expected, control.BackColor);
        Assert.False(control.UseVisualStyleBackColor);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(CommonTestHelperEx), nameof(CommonTestHelperEx.GetBackColorTheoryData))]
    public void TabPage_BackColor_SetDesignMode_GetReturnsExpected(Color value, Color expected)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(IDictionaryService)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(IExtenderListService)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(IComponentChangeService)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(ITypeDescriptorFilterService)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabPage control = new()
        {
            Site = mockSite.Object,
            BackColor = value
        };
        Assert.Equal(expected, control.BackColor);
        Assert.False(control.UseVisualStyleBackColor);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.BackColor = value;
        Assert.Equal(expected, control.BackColor);
        Assert.False(control.UseVisualStyleBackColor);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(CommonTestHelperEx), nameof(CommonTestHelperEx.GetBackColorTheoryData))]
    public void TabPage_BackColor_SetDesignModeWithUseVisualStyleBackColor_GetReturnsExpected(Color value, Color expected)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(IDictionaryService)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(IExtenderListService)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(IComponentChangeService)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(ITypeDescriptorFilterService)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabPage control = new()
        {
            Site = mockSite.Object,
            UseVisualStyleBackColor = true,
            BackColor = value
        };
        Assert.Equal(expected, control.BackColor);
        Assert.Equal(value.IsEmpty, control.UseVisualStyleBackColor);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.BackColor = value;
        Assert.Equal(expected, control.BackColor);
        Assert.Equal(value.IsEmpty, control.UseVisualStyleBackColor);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(CommonTestHelperEx), nameof(CommonTestHelperEx.GetBackColorTheoryData))]
    public void TabPage_BackColor_SetDesignModeWithInvalidDescriptor_GetReturnsExpected(Color value, Color expected)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(IDictionaryService)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(IExtenderListService)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(IComponentChangeService)))
            .Returns(null);
        mockSite
            .Setup(s => s.GetService(typeof(ITypeDescriptorFilterService)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabPage control = new()
        {
            Site = mockSite.Object,
            UseVisualStyleBackColor = true,
        };
        Mock<ICustomTypeDescriptor> mockCustomTypeDescriptor = new(MockBehavior.Strict);
        mockCustomTypeDescriptor
            .Setup(d => d.GetProperties())
            .Returns(PropertyDescriptorCollection.Empty);
        Mock<TypeDescriptionProvider> mockProvider = new(MockBehavior.Strict);
        mockProvider
            .Setup(p => p.GetCache(control))
            .CallBase();
        mockProvider
            .Setup(p => p.GetExtendedTypeDescriptor(control))
            .CallBase();
        mockProvider
            .Setup(p => p.GetTypeDescriptor(typeof(TabPage), control))
            .Returns(mockCustomTypeDescriptor.Object);
        TypeDescriptor.AddProvider(mockProvider.Object, control);

        control.BackColor = value;
        Assert.Equal(expected, control.BackColor);
        Assert.True(control.UseVisualStyleBackColor);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.BackColor = value;
        Assert.Equal(expected, control.BackColor);
        Assert.True(control.UseVisualStyleBackColor);
        Assert.False(control.IsHandleCreated);
    }

    public static IEnumerable<object[]> BackColor_SetWithHandle_TestData()
    {
        yield return new object[] { Color.Red, Color.Red, 1 };
        yield return new object[] { Color.Empty, Control.DefaultBackColor, 0 };
    }

    [WinFormsTheory]
    [MemberData(nameof(BackColor_SetWithHandle_TestData))]
    public void TabPage_BackColor_SetWithHandle_GetReturnsExpected(Color value, Color expected, int expectedInvalidatedCallCount)
    {
        using TabPage control = new();
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        control.BackColor = value;
        Assert.Equal(expected, control.BackColor);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set same.
        control.BackColor = value;
        Assert.Equal(expected, control.BackColor);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsFact]
    public void TabPage_BackColor_SetWithHandler_CallsBackColorChanged()
    {
        using TabPage control = new();
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            callCount++;
        };
        control.BackColorChanged += handler;

        // Set different.
        control.BackColor = Color.Red;
        Assert.Equal(Color.Red, control.BackColor);
        Assert.Equal(1, callCount);

        // Set same.
        control.BackColor = Color.Red;
        Assert.Equal(Color.Red, control.BackColor);
        Assert.Equal(1, callCount);

        // Set different.
        control.BackColor = Color.Empty;
        Assert.Equal(Control.DefaultBackColor, control.BackColor);
        Assert.Equal(2, callCount);

        // Remove handler.
        control.BackColorChanged -= handler;
        control.BackColor = Color.Red;
        Assert.Equal(Color.Red, control.BackColor);
        Assert.Equal(2, callCount);
    }

    [WinFormsTheory]
    [EnumData<DockStyle>]
    public void TabPage_Dock_Set_GetReturnsExpected(DockStyle value)
    {
        using TabPage control = new()
        {
            Dock = value
        };
        Assert.Equal(value, control.Dock);
        Assert.Equal(AnchorStyles.Top | AnchorStyles.Left, control.Anchor);

        // Set same.
        control.Dock = value;
        Assert.Equal(value, control.Dock);
        Assert.Equal(AnchorStyles.Top | AnchorStyles.Left, control.Anchor);
    }

    [WinFormsTheory]
    [EnumData<DockStyle>]
    public void TabPage_Dock_SetWithOldValue_GetReturnsExpected(DockStyle value)
    {
        using TabPage control = new()
        {
            Dock = DockStyle.Top
        };

        control.Dock = value;
        Assert.Equal(value, control.Dock);
        Assert.Equal(AnchorStyles.Top | AnchorStyles.Left, control.Anchor);

        // Set same.
        control.Dock = value;
        Assert.Equal(value, control.Dock);
        Assert.Equal(AnchorStyles.Top | AnchorStyles.Left, control.Anchor);
    }

    [WinFormsTheory]
    [MemberData(nameof(ControlTests.Dock_SetWithAnchor_TestData), MemberType = typeof(ControlTests))]
    public void TabPage_Dock_SetWithAnchor_GetReturnsExpected(AnchorStyles anchor, DockStyle value, AnchorStyles expectedAnchor)
    {
        using TabPage control = new()
        {
            Anchor = anchor
        };

        control.Dock = value;
        Assert.Equal(value, control.Dock);
        Assert.Equal(expectedAnchor, control.Anchor);

        // Set same.
        control.Dock = value;
        Assert.Equal(value, control.Dock);
        Assert.Equal(expectedAnchor, control.Anchor);
    }

    [WinFormsFact]
    public void TabPage_Dock_SetWithHandler_CallsDockChanged()
    {
        using TabPage control = new()
        {
            Dock = DockStyle.None
        };
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            callCount++;
        };
        control.DockChanged += handler;

        // Set different.
        control.Dock = DockStyle.Top;
        Assert.Equal(DockStyle.Top, control.Dock);
        Assert.Equal(1, callCount);

        // Set same.
        control.Dock = DockStyle.Top;
        Assert.Equal(DockStyle.Top, control.Dock);
        Assert.Equal(1, callCount);

        // Set different.
        control.Dock = DockStyle.Left;
        Assert.Equal(DockStyle.Left, control.Dock);
        Assert.Equal(2, callCount);

        // Remove handler.
        control.DockChanged -= handler;
        control.Dock = DockStyle.Top;
        Assert.Equal(DockStyle.Top, control.Dock);
        Assert.Equal(2, callCount);
    }

    [WinFormsTheory]
    [InvalidEnumData<DockStyle>]
    public void TabPage_Dock_SetInvalid_ThrowsInvalidEnumArgumentException(DockStyle value)
    {
        using TabPage control = new();
        Assert.Throws<InvalidEnumArgumentException>("value", () => control.Dock = value);
    }

    [WinFormsTheory]
    [BoolData]
    public void TabPage_Enabled_Set_GetReturnsExpected(bool value)
    {
        using TabPage control = new()
        {
            Enabled = value
        };
        Assert.Equal(value, control.Enabled);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.Enabled = value;
        Assert.Equal(value, control.Enabled);
        Assert.False(control.IsHandleCreated);

        // Set different.
        control.Enabled = !value;
        Assert.Equal(!value, control.Enabled);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [InlineData(true, false, 1, 2)]
    [InlineData(true, true, 0, 1)]
    [InlineData(false, false, 0, 0)]
    [InlineData(false, true, 0, 0)]
    public void TabPage_Enabled_SetWithHandle_GetReturnsExpected(bool userPaint, bool value, int expectedInvalidateCallCount1, int expectedInvalidateCallCount2)
    {
        using SubTabPage control = new();
        control.SetStyle(ControlStyles.UserPaint, userPaint);
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        Assert.Equal(userPaint, control.GetStyle(ControlStyles.UserPaint));

        control.Enabled = value;
        Assert.Equal(value, control.Enabled);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidateCallCount1, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set same.
        control.Enabled = value;
        Assert.Equal(value, control.Enabled);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidateCallCount1, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set different.
        control.Enabled = !value;
        Assert.Equal(!value, control.Enabled);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidateCallCount2, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsFact]
    public void TabPage_Enabled_SetWithHandler_CallsEnabledChanged()
    {
        using TabPage control = new()
        {
            Enabled = true
        };
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            callCount++;
        };
        control.EnabledChanged += handler;

        // Set different.
        control.Enabled = false;
        Assert.False(control.Enabled);
        Assert.Equal(1, callCount);

        // Set same.
        control.Enabled = false;
        Assert.False(control.Enabled);
        Assert.Equal(1, callCount);

        // Set different.
        control.Enabled = true;
        Assert.True(control.Enabled);
        Assert.Equal(2, callCount);

        // Remove handler.
        control.EnabledChanged -= handler;
        control.Enabled = false;
        Assert.False(control.Enabled);
        Assert.Equal(2, callCount);
    }

    [WinFormsTheory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void TabPage_ImageIndex_Set_GetReturnsExpected(int value)
    {
        using TabPage control = new()
        {
            ImageIndex = value
        };
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.True(control.Visible);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.ImageIndex = value;
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.True(control.Visible);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void TabPage_ImageIndex_SetWithParent_GetReturnsExpected(int value)
    {
        using TabControl parent = new();
        using TabPage control = new()
        {
            Parent = parent,
            ImageIndex = value
        };
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);

        // Set same.
        control.ImageIndex = value;
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);
    }

    [WinFormsTheory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void TabPage_ImageIndex_SetWithDesignModeParent_GetReturnsExpected(int value)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl parent = new()
        {
            Site = mockSite.Object
        };
        using TabPage control = new()
        {
            Parent = parent,
            ImageIndex = value
        };
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);

        // Set same.
        control.ImageIndex = value;
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);
    }

    [WinFormsTheory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void TabPage_ImageIndex_SetWithImageKey_GetReturnsExpected(int value)
    {
        using TabPage control = new()
        {
            ImageKey = "imageKey",
            ImageIndex = value
        };
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.True(control.Visible);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.ImageIndex = value;
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.True(control.Visible);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void TabPage_ImageIndex_SetWithHandle_GetReturnsExpected(int value)
    {
        using TabPage control = new();
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        control.ImageIndex = value;
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set same.
        control.ImageIndex = value;
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsTheory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void TabPage_ImageIndex_SetWithParentWithHandle_GetReturnsExpected(int value)
    {
        using TabControl parent = new();
        using TabPage control = new()
        {
            Parent = parent
        };
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;

        control.ImageIndex = value;
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(1, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);

        // Set same.
        control.ImageIndex = value;
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(2, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);
    }

    [WinFormsTheory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void TabPage_ImageIndex_SetWithDesignModeParentWithHandle_GetReturnsExpected(int value)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl parent = new()
        {
            Site = mockSite.Object
        };
        using TabPage control = new()
        {
            Parent = parent
        };
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;

        control.ImageIndex = value;
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(1, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);

        // Set same.
        control.ImageIndex = value;
        Assert.Equal(value, control.ImageIndex);
        Assert.Empty(control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(2, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);
    }

    [WinFormsTheory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public unsafe void TabPageCollection_ImageIndex_SetGetItemsWithHandle_Success(int imageIndex)
    {
        using TabControl owner = new();
        using TabPage page1 = new();
        using TabPage page2 = new()
        {
            Text = "Text",
            ImageIndex = 1
        };
        using NullTextTabPage page3 = new();
        owner.TabPages.Add(page1);
        owner.TabPages.Add(page2);
        owner.TabPages.Add(page3);
        Assert.NotEqual(IntPtr.Zero, owner.Handle);

        page2.ImageIndex = imageIndex;
        Assert.Equal(3, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMCOUNT));

        char* buffer = stackalloc char[256];
        TCITEMW item = default;
        item.cchTextMax = int.MaxValue;
        item.pszText = buffer;
        item.dwStateMask = (TAB_CONTROL_ITEM_STATE)uint.MaxValue;
        item.mask = (TCITEMHEADERA_MASK)uint.MaxValue;

        // Get item 0.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 0, ref item));
        Assert.Equal(TAB_CONTROL_ITEM_STATE.TCIS_BUTTONPRESSED, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);

        // Get item 1.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 1, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Equal("Text", new string(item.pszText));
        Assert.Equal(imageIndex, item.iImage);

        // Get item 2.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 2, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);
    }

    [WinFormsTheory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public unsafe void TabPageCollection_ImageIndex_SetGetItemsWithHandleDesignMode_Success(int imageIndex)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl owner = new()
        {
            Site = mockSite.Object
        };
        using TabPage page1 = new();
        using TabPage page2 = new()
        {
            Text = "Text",
            ImageIndex = 1
        };
        using NullTextTabPage page3 = new();
        owner.TabPages.Add(page1);
        owner.TabPages.Add(page2);
        owner.TabPages.Add(page3);
        Assert.NotEqual(IntPtr.Zero, owner.Handle);

        page2.ImageIndex = imageIndex;
        Assert.Equal(3, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMCOUNT));

        char* buffer = stackalloc char[256];
        TCITEMW item = default;
        item.cchTextMax = int.MaxValue;
        item.pszText = buffer;
        item.dwStateMask = (TAB_CONTROL_ITEM_STATE)uint.MaxValue;
        item.mask = (TCITEMHEADERA_MASK)uint.MaxValue;

        // Get item 0.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 0, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);

        // Get item 1.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 1, ref item));
        Assert.Equal(TAB_CONTROL_ITEM_STATE.TCIS_BUTTONPRESSED, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Equal("Text", new string(item.pszText));
        Assert.Equal(imageIndex, item.iImage);

        // Get item 2.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 2, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);
    }

    [WinFormsFact]
    public void TabPage_ImageIndex_SetInvalidValue_ThrowsArgumentOutOfRangeException()
    {
        using TabPage control = new();
        Assert.Throws<ArgumentOutOfRangeException>("value", () => control.ImageIndex = -2);
    }

    [WinFormsTheory]
    [StringData]
    public void TabPage_ImageKey_Set_GetReturnsExpected(string value)
    {
        using TabPage control = new()
        {
            ImageKey = value
        };
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.ImageKey = value;
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [StringData]
    public void TabPage_ImageKey_SetWithParent_GetReturnsExpected(string value)
    {
        using TabControl parent = new();
        using TabPage control = new()
        {
            ImageKey = value
        };
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);

        // Set same.
        control.ImageKey = value;
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);
    }

    [WinFormsTheory]
    [StringData]
    public void TabPage_ImageKey_SetWithDesignModeParent_GetReturnsExpected(string value)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl parent = new()
        {
            Site = mockSite.Object
        };
        using TabPage control = new()
        {
            ImageKey = value
        };
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);

        // Set same.
        control.ImageKey = value;
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);
    }

    [WinFormsTheory]
    [StringData]
    public void TabPage_ImageKey_SetWithImageIndex_GetReturnsExpected(string value)
    {
        using TabPage control = new()
        {
            ImageIndex = 1,
            ImageKey = value
        };
        Assert.Equal(-1, control.ImageIndex);
        Assert.True(control.Visible);
        Assert.Equal(value, control.ImageKey);

        // Set same.
        control.ImageKey = value;
        Assert.Equal(-1, control.ImageIndex);
        Assert.True(control.Visible);
        Assert.Equal(value, control.ImageKey);
    }

    [WinFormsTheory]
    [StringData]
    public void TabPage_ImageKey_SetWithHandle_GetReturnsExpected(string value)
    {
        using TabPage control = new();
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        control.ImageKey = value;
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set same.
        control.ImageKey = value;
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsTheory]
    [StringData]
    public void TabPage_ImageKey_SetWithHandleWithParent_GetReturnsExpected(string value)
    {
        using TabControl parent = new();
        using TabPage control = new()
        {
            Parent = parent
        };
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;

        control.ImageKey = value;
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(1, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);

        // Set same.
        control.ImageKey = value;
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(2, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);
    }

    [WinFormsTheory]
    [StringData]
    public void TabPage_ImageKey_SetWithDesignModeParentWithHandle_GetReturnsExpected(string value)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl parent = new()
        {
            Site = mockSite.Object
        };
        using TabPage control = new()
        {
            Parent = parent
        };
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;

        control.ImageKey = value;
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(1, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);

        // Set same.
        control.ImageKey = value;
        Assert.Equal(-1, control.ImageIndex);
        Assert.Equal(value, control.ImageKey);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(2, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);
    }

    [WinFormsFact]
    public unsafe void TabPageCollection_ImageKey_SetGetItemsWithHandle_Success()
    {
        using TabControl owner = new();
        using TabPage page1 = new();
        using TabPage page2 = new()
        {
            Text = "Text",
            ImageIndex = 1
        };
        using NullTextTabPage page3 = new();
        owner.TabPages.Add(page1);
        owner.TabPages.Add(page2);
        owner.TabPages.Add(page3);
        Assert.NotEqual(IntPtr.Zero, owner.Handle);

        page2.ImageKey = "ImageKey";
        Assert.Equal(3, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMCOUNT));

        char* buffer = stackalloc char[256];
        TCITEMW item = default;
        item.cchTextMax = int.MaxValue;
        item.pszText = buffer;
        item.dwStateMask = (TAB_CONTROL_ITEM_STATE)uint.MaxValue;
        item.mask = (TCITEMHEADERA_MASK)uint.MaxValue;

        // Get item 0.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 0, ref item));
        Assert.Equal(TAB_CONTROL_ITEM_STATE.TCIS_BUTTONPRESSED, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);

        // Get item 1.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 1, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Equal("Text", new string(item.pszText));
        Assert.Equal(-1, item.iImage);

        // Get item 2.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 2, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);
    }

    [WinFormsFact]
    public unsafe void TabPageCollection_ImageKey_SetGetItemsWithHandleDesignMode_Success()
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl owner = new()
        {
            Site = mockSite.Object
        };
        using TabPage page1 = new();
        using TabPage page2 = new()
        {
            Text = "Text",
            ImageIndex = 1
        };
        using NullTextTabPage page3 = new();
        owner.TabPages.Add(page1);
        owner.TabPages.Add(page2);
        owner.TabPages.Add(page3);
        Assert.NotEqual(IntPtr.Zero, owner.Handle);

        page2.ImageKey = "ImageKey";
        Assert.Equal(3, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMCOUNT));

        char* buffer = stackalloc char[256];
        TCITEMW item = default;
        item.cchTextMax = int.MaxValue;
        item.pszText = buffer;
        item.dwStateMask = (TAB_CONTROL_ITEM_STATE)uint.MaxValue;
        item.mask = (TCITEMHEADERA_MASK)uint.MaxValue;

        // Get item 0.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 0, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);

        // Get item 1.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 1, ref item));
        Assert.Equal(TAB_CONTROL_ITEM_STATE.TCIS_BUTTONPRESSED, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Equal("Text", new string(item.pszText));
        Assert.Equal(-1, item.iImage);

        // Get item 2.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 2, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);
    }

    public static IEnumerable<object[]> Location_Set_TestData()
    {
        yield return new object[] { new Point(0, 0), 0 };
        yield return new object[] { new Point(-1, -2), 1 };
        yield return new object[] { new Point(1, 0), 1 };
        yield return new object[] { new Point(0, 2), 1 };
        yield return new object[] { new Point(1, 2), 1 };
    }

    [WinFormsTheory]
    [MemberData(nameof(Location_Set_TestData))]
    public void TabPage_Location_Set_GetReturnsExpected(Point value, int expectedLocationChangedCallCount)
    {
        using TabPage control = new();
        int moveCallCount = 0;
        int locationChangedCallCount = 0;
        int layoutCallCount = 0;
        int resizeCallCount = 0;
        int sizeChangedCallCount = 0;
        int clientSizeChangedCallCount = 0;
        control.Move += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(locationChangedCallCount, moveCallCount);
            moveCallCount++;
        };
        control.LocationChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(moveCallCount - 1, locationChangedCallCount);
            locationChangedCallCount++;
        };
        control.Layout += (sender, e) => layoutCallCount++;
        control.Resize += (sender, e) => resizeCallCount++;
        control.SizeChanged += (sender, e) => sizeChangedCallCount++;
        control.ClientSizeChanged += (sender, e) => clientSizeChangedCallCount++;

        control.Location = value;
        Assert.Equal(new Size(200, 100), control.ClientSize);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.ClientRectangle);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.DisplayRectangle);
        Assert.Equal(new Size(200, 100), control.Size);
        Assert.Equal(value.X, control.Left);
        Assert.Equal(value.X + 200, control.Right);
        Assert.Equal(value, control.Location);
        Assert.Equal(value.Y, control.Top);
        Assert.Equal(value.Y + 100, control.Bottom);
        Assert.Equal(200, control.Width);
        Assert.Equal(100, control.Height);
        Assert.Equal(new Rectangle(value.X, value.Y, 200, 100), control.Bounds);
        Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
        Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
        Assert.Equal(0, layoutCallCount);
        Assert.Equal(0, resizeCallCount);
        Assert.Equal(0, sizeChangedCallCount);
        Assert.Equal(0, clientSizeChangedCallCount);
        Assert.False(control.IsHandleCreated);

        // Call again.
        control.Location = value;
        Assert.Equal(new Size(200, 100), control.ClientSize);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.ClientRectangle);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.DisplayRectangle);
        Assert.Equal(new Size(200, 100), control.Size);
        Assert.Equal(value.X, control.Left);
        Assert.Equal(value.X + 200, control.Right);
        Assert.Equal(value, control.Location);
        Assert.Equal(value.Y, control.Top);
        Assert.Equal(value.Y + 100, control.Bottom);
        Assert.Equal(200, control.Width);
        Assert.Equal(100, control.Height);
        Assert.Equal(new Rectangle(value.X, value.Y, 200, 100), control.Bounds);
        Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
        Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
        Assert.Equal(0, layoutCallCount);
        Assert.Equal(0, resizeCallCount);
        Assert.Equal(0, sizeChangedCallCount);
        Assert.Equal(0, clientSizeChangedCallCount);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [MemberData(nameof(Location_Set_TestData))]
    public void TabPage_Location_SetWithParent_GetReturnsExpected(Point value, int expectedLocationChangedCallCount)
    {
        using TabControl parent = new();
        using SubTabPage control = new()
        {
            Parent = parent
        };
        int layoutCallCount = 0;
        int moveCallCount = 0;
        int locationChangedCallCount = 0;
        int resizeCallCount = 0;
        int sizeChangedCallCount = 0;
        int clientSizeChangedCallCount = 0;
        int parentLayoutCallCount = 0;
        control.Move += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(locationChangedCallCount, moveCallCount);
            moveCallCount++;
        };
        control.LocationChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(moveCallCount - 1, locationChangedCallCount);
            locationChangedCallCount++;
        };
        control.Layout += (sender, e) => layoutCallCount++;
        control.Resize += (sender, e) => resizeCallCount++;
        control.SizeChanged += (sender, e) => sizeChangedCallCount++;
        control.ClientSizeChanged += (sender, e) => clientSizeChangedCallCount++;
        void parentHandler(object sender, LayoutEventArgs e)
        {
            Assert.Same(parent, sender);
            Assert.Same(control, e.AffectedControl);
            Assert.Equal("Bounds", e.AffectedProperty);
            parentLayoutCallCount++;
        }

        parent.Layout += parentHandler;

        try
        {
            control.Location = value;
            Assert.Equal(new Size(200, 100), control.ClientSize);
            Assert.Equal(new Rectangle(0, 0, 200, 100), control.ClientRectangle);
            Assert.Equal(new Rectangle(0, 0, 200, 100), control.DisplayRectangle);
            Assert.Equal(new Size(200, 100), control.Size);
            Assert.Equal(value.X, control.Left);
            Assert.Equal(value.X + 200, control.Right);
            Assert.Equal(value, control.Location);
            Assert.Equal(value.Y, control.Top);
            Assert.Equal(value.Y + 100, control.Bottom);
            Assert.Equal(200, control.Width);
            Assert.Equal(100, control.Height);
            Assert.Equal(new Rectangle(value.X, value.Y, 200, 100), control.Bounds);
            Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
            Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
            Assert.Equal(0, layoutCallCount);
            Assert.Equal(0, resizeCallCount);
            Assert.Equal(0, sizeChangedCallCount);
            Assert.Equal(0, clientSizeChangedCallCount);
            Assert.Equal(expectedLocationChangedCallCount, parentLayoutCallCount);
            Assert.False(control.IsHandleCreated);

            // Call again.
            control.Location = value;
            Assert.Equal(new Size(200, 100), control.ClientSize);
            Assert.Equal(new Rectangle(0, 0, 200, 100), control.ClientRectangle);
            Assert.Equal(new Rectangle(0, 0, 200, 100), control.DisplayRectangle);
            Assert.Equal(new Size(200, 100), control.Size);
            Assert.Equal(value.X, control.Left);
            Assert.Equal(value.X + 200, control.Right);
            Assert.Equal(value, control.Location);
            Assert.Equal(value.Y, control.Top);
            Assert.Equal(value.Y + 100, control.Bottom);
            Assert.Equal(200, control.Width);
            Assert.Equal(100, control.Height);
            Assert.Equal(new Rectangle(value.X, value.Y, 200, 100), control.Bounds);
            Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
            Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
            Assert.Equal(0, layoutCallCount);
            Assert.Equal(0, resizeCallCount);
            Assert.Equal(0, sizeChangedCallCount);
            Assert.Equal(0, clientSizeChangedCallCount);
            Assert.Equal(expectedLocationChangedCallCount, parentLayoutCallCount);
            Assert.False(control.IsHandleCreated);
        }
        finally
        {
            parent.Layout -= parentHandler;
        }
    }

    public static IEnumerable<object[]> Location_SetWithHandle_TestData()
    {
        foreach (bool resizeRedraw in new bool[] { true, false })
        {
            yield return new object[] { resizeRedraw, new Point(0, 0), 0 };
            yield return new object[] { resizeRedraw, new Point(-1, -2), 1 };
            yield return new object[] { resizeRedraw, new Point(1, 0), 1 };
            yield return new object[] { resizeRedraw, new Point(0, 2), 1 };
            yield return new object[] { resizeRedraw, new Point(1, 2), 1 };
        }
    }

    [WinFormsTheory]
    [MemberData(nameof(Location_SetWithHandle_TestData))]
    public void TabPage_Location_SetWithHandle_GetReturnsExpected(bool resizeRedraw, Point value, int expectedLocationChangedCallCount)
    {
        using SubTabPage control = new();
        control.SetStyle(ControlStyles.ResizeRedraw, resizeRedraw);
        int moveCallCount = 0;
        int locationChangedCallCount = 0;
        int layoutCallCount = 0;
        int resizeCallCount = 0;
        int sizeChangedCallCount = 0;
        int clientSizeChangedCallCount = 0;
        control.Move += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(locationChangedCallCount, moveCallCount);
            moveCallCount++;
        };
        control.LocationChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(moveCallCount - 1, locationChangedCallCount);
            locationChangedCallCount++;
        };
        control.Layout += (sender, e) => layoutCallCount++;
        control.Resize += (sender, e) => resizeCallCount++;
        control.SizeChanged += (sender, e) => sizeChangedCallCount++;
        control.ClientSizeChanged += (sender, e) => clientSizeChangedCallCount++;
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        control.Location = value;
        Assert.Equal(new Size(200, 100), control.ClientSize);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.ClientRectangle);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.DisplayRectangle);
        Assert.Equal(new Size(200, 100), control.Size);
        Assert.Equal(value.X, control.Left);
        Assert.Equal(value.X + 200, control.Right);
        Assert.Equal(value, control.Location);
        Assert.Equal(value.Y, control.Top);
        Assert.Equal(value.Y + 100, control.Bottom);
        Assert.Equal(200, control.Width);
        Assert.Equal(100, control.Height);
        Assert.Equal(new Rectangle(value.X, value.Y, 200, 100), control.Bounds);
        Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
        Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
        Assert.Equal(0, layoutCallCount);
        Assert.Equal(0, resizeCallCount);
        Assert.Equal(0, sizeChangedCallCount);
        Assert.Equal(0, clientSizeChangedCallCount);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Call again.
        control.Location = value;
        Assert.Equal(new Size(200, 100), control.ClientSize);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.ClientRectangle);
        Assert.Equal(new Rectangle(0, 0, 200, 100), control.DisplayRectangle);
        Assert.Equal(new Size(200, 100), control.Size);
        Assert.Equal(value.X, control.Left);
        Assert.Equal(value.X + 200, control.Right);
        Assert.Equal(value, control.Location);
        Assert.Equal(value.Y, control.Top);
        Assert.Equal(value.Y + 100, control.Bottom);
        Assert.Equal(200, control.Width);
        Assert.Equal(100, control.Height);
        Assert.Equal(new Rectangle(value.X, value.Y, 200, 100), control.Bounds);
        Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
        Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
        Assert.Equal(0, layoutCallCount);
        Assert.Equal(0, resizeCallCount);
        Assert.Equal(0, sizeChangedCallCount);
        Assert.Equal(0, clientSizeChangedCallCount);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    public static IEnumerable<object[]> Location_SetWithParentWithHandle_TestData()
    {
        foreach (bool resizeRedraw in new bool[] { true, false })
        {
            yield return new object[] { resizeRedraw, new Point(0, 0) };
            yield return new object[] { resizeRedraw, new Point(-1, -2) };
            yield return new object[] { resizeRedraw, new Point(1, 0) };
            yield return new object[] { resizeRedraw, new Point(0, 2) };
            yield return new object[] { resizeRedraw, new Point(1, 2) };
        }
    }

    [WinFormsTheory]
    [MemberData(nameof(Location_SetWithParentWithHandle_TestData))]
    public void TabPage_Location_SetWithParentWithHandle_GetReturnsExpected(bool resizeRedraw, Point value)
    {
        using TabControl parent = new();
        using SubTabPage control = new()
        {
            Parent = parent
        };
        control.SetStyle(ControlStyles.ResizeRedraw, resizeRedraw);
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;
        Rectangle expected = parent.DisplayRectangle;

        int moveCallCount = 0;
        int locationChangedCallCount = 0;
        int layoutCallCount = 0;
        int resizeCallCount = 0;
        int sizeChangedCallCount = 0;
        int clientSizeChangedCallCount = 0;
        int parentLayoutCallCount = 0;
        control.Move += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(locationChangedCallCount, moveCallCount);
            moveCallCount++;
        };
        control.LocationChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(moveCallCount - 1, locationChangedCallCount);
            locationChangedCallCount++;
        };
        control.Layout += (sender, e) => layoutCallCount++;
        control.Resize += (sender, e) => resizeCallCount++;
        control.SizeChanged += (sender, e) => sizeChangedCallCount++;
        control.ClientSizeChanged += (sender, e) => clientSizeChangedCallCount++;
        void parentHandler(object sender, LayoutEventArgs e)
        {
            Assert.Same(parent, sender);
            Assert.Same(control, e.AffectedControl);
            Assert.Equal("Bounds", e.AffectedProperty);
            parentLayoutCallCount++;
        }

        parent.Layout += parentHandler;

        try
        {
            control.Location = value;
            Assert.Equal(expected.Size, control.ClientSize);
            Assert.Equal(new Rectangle(0, 0, expected.Width, expected.Height), control.ClientRectangle);
            Assert.Equal(new Rectangle(0, 0, expected.Width, expected.Height), control.DisplayRectangle);
            Assert.Equal(expected.Size, control.Size);
            Assert.Equal(expected.X, control.Left);
            Assert.Equal(expected.X + expected.Width, control.Right);
            Assert.Equal(expected.Location, control.Location);
            Assert.Equal(expected.Y, control.Top);
            Assert.Equal(expected.Y + expected.Height, control.Bottom);
            Assert.Equal(expected.Width, control.Width);
            Assert.Equal(expected.Height, control.Height);
            Assert.Equal(expected, control.Bounds);
            Assert.Equal(0, moveCallCount);
            Assert.Equal(0, locationChangedCallCount);
            Assert.Equal(0, layoutCallCount);
            Assert.Equal(1, parentLayoutCallCount);
            Assert.Equal(0, resizeCallCount);
            Assert.Equal(0, sizeChangedCallCount);
            Assert.Equal(0, clientSizeChangedCallCount);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
            Assert.True(parent.IsHandleCreated);
            Assert.Equal(0, parentInvalidatedCallCount);
            Assert.Equal(0, parentStyleChangedCallCount);
            Assert.Equal(0, parentCreatedCallCount);

            // Call again.
            control.Location = value;
            Assert.Equal(expected.Size, control.ClientSize);
            Assert.Equal(new Rectangle(0, 0, expected.Width, expected.Height), control.ClientRectangle);
            Assert.Equal(new Rectangle(0, 0, expected.Width, expected.Height), control.DisplayRectangle);
            Assert.Equal(expected.Size, control.Size);
            Assert.Equal(expected.X, control.Left);
            Assert.Equal(expected.X + expected.Width, control.Right);
            Assert.Equal(expected.Location, control.Location);
            Assert.Equal(expected.Y, control.Top);
            Assert.Equal(expected.Y + expected.Height, control.Bottom);
            Assert.Equal(expected.Width, control.Width);
            Assert.Equal(expected.Height, control.Height);
            Assert.Equal(expected, control.Bounds);
            Assert.Equal(0, moveCallCount);
            Assert.Equal(0, locationChangedCallCount);
            Assert.Equal(0, layoutCallCount);
            Assert.Equal(2, parentLayoutCallCount);
            Assert.Equal(0, resizeCallCount);
            Assert.Equal(0, sizeChangedCallCount);
            Assert.Equal(0, clientSizeChangedCallCount);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
            Assert.True(parent.IsHandleCreated);
            Assert.Equal(0, parentInvalidatedCallCount);
            Assert.Equal(0, parentStyleChangedCallCount);
            Assert.Equal(0, parentCreatedCallCount);
        }
        finally
        {
            parent.Layout -= parentHandler;
        }
    }

    [WinFormsTheory]
    [InlineData(true, 1)]
    [InlineData(false, 0)]
    public void TabPage_Location_SetWithHandleWithTransparentBackColor_DoesNotCallInvalidate(bool supportsTransparentBackgroundColor, int expectedInvalidatedCallCount)
    {
        using SubTabPage control = new();
        control.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        control.BackColor = Color.FromArgb(254, 255, 255, 255);
        control.SetStyle(ControlStyles.SupportsTransparentBackColor, supportsTransparentBackgroundColor);

        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;

        // Set different.
        control.Location = new Point(1, 2);
        Assert.Equal(new Point(1, 2), control.Location);
        Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);

        // Set same.
        control.Location = new Point(1, 2);
        Assert.Equal(new Point(1, 2), control.Location);
        Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);

        // Set different.
        control.Location = new Point(2, 3);
        Assert.Equal(new Point(2, 3), control.Location);
        Assert.Equal(expectedInvalidatedCallCount * 2, invalidatedCallCount);
    }

    [WinFormsFact]
    public void TabPage_Location_SetWithHandler_CallsLocationChanged()
    {
        using TabPage control = new();
        int locationChangedCallCount = 0;
        EventHandler locationChangedHandler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            locationChangedCallCount++;
        };
        control.LocationChanged += locationChangedHandler;
        int moveCallCount = 0;
        EventHandler moveHandler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            moveCallCount++;
        };
        control.Move += moveHandler;

        // Set different.
        control.Location = new Point(1, 2);
        Assert.Equal(new Point(1, 2), control.Location);
        Assert.Equal(1, locationChangedCallCount);
        Assert.Equal(1, moveCallCount);

        // Set same.
        control.Location = new Point(1, 2);
        Assert.Equal(new Point(1, 2), control.Location);
        Assert.Equal(1, locationChangedCallCount);
        Assert.Equal(1, moveCallCount);

        // Set different x.
        control.Location = new Point(2, 2);
        Assert.Equal(new Point(2, 2), control.Location);
        Assert.Equal(2, locationChangedCallCount);
        Assert.Equal(2, moveCallCount);

        // Set different y.
        control.Location = new Point(2, 3);
        Assert.Equal(new Point(2, 3), control.Location);
        Assert.Equal(3, locationChangedCallCount);
        Assert.Equal(3, moveCallCount);

        // Remove handler.
        control.LocationChanged -= locationChangedHandler;
        control.Move -= moveHandler;
        control.Location = new Point(1, 2);
        Assert.Equal(new Point(1, 2), control.Location);
        Assert.Equal(3, locationChangedCallCount);
        Assert.Equal(3, moveCallCount);
    }

    [WinFormsFact]
    public void TabPage_Location_ResetValue_Success()
    {
        PropertyDescriptor property = TypeDescriptor.GetProperties(typeof(TabPage))[nameof(TabPage.Location)];
        using TabPage control = new();
        Assert.False(property.CanResetValue(control));

        control.Location = new Point(1, 0);
        Assert.Equal(new Point(1, 0), control.Location);
        Assert.False(property.CanResetValue(control));

        control.Location = new Point(0, 1);
        Assert.Equal(new Point(0, 1), control.Location);
        Assert.False(property.CanResetValue(control));

        control.Location = new Point(1, 2);
        Assert.Equal(new Point(1, 2), control.Location);
        Assert.False(property.CanResetValue(control));

        property.ResetValue(control);
        Assert.Equal(new Point(1, 2), control.Location);
        Assert.False(property.CanResetValue(control));

        control.Location = Point.Empty;
        Assert.Equal(Point.Empty, control.Location);
        Assert.False(property.CanResetValue(control));
    }

    [WinFormsFact]
    public void TabPage_Location_ShouldSerializeValue_Success()
    {
        PropertyDescriptor property = TypeDescriptor.GetProperties(typeof(TabPage))[nameof(TabPage.Location)];
        using TabPage control = new();
        Assert.False(property.ShouldSerializeValue(control));

        control.Location = new Point(1, 0);
        Assert.Equal(new Point(1, 0), control.Location);
        Assert.True(property.ShouldSerializeValue(control));

        control.Location = new Point(0, 1);
        Assert.Equal(new Point(0, 1), control.Location);
        Assert.True(property.ShouldSerializeValue(control));

        control.Location = new Point(1, 2);
        Assert.Equal(new Point(1, 2), control.Location);
        Assert.True(property.ShouldSerializeValue(control));

        property.ResetValue(control);
        Assert.Equal(new Point(1, 2), control.Location);
        Assert.True(property.ShouldSerializeValue(control));

        control.Location = Point.Empty;
        Assert.Equal(Point.Empty, control.Location);
        Assert.False(property.ShouldSerializeValue(control));
    }

    [WinFormsTheory]
    [MemberData(nameof(ControlTests.MaximumSize_Set_TestData), MemberType = typeof(ControlTests))]
    public void TabPage_MaximumSize_Set_GetReturnsExpected(Size value)
    {
        using TabPage control = new()
        {
            Size = Size.Empty
        };
        int layoutCallCount = 0;
        control.Layout += (sender, e) => layoutCallCount++;

        control.MaximumSize = value;
        Assert.Equal(value, control.MaximumSize);
        Assert.Equal(Size.Empty, control.Size);
        Assert.Equal(0, layoutCallCount);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.MaximumSize = value;
        Assert.Equal(value, control.MaximumSize);
        Assert.Equal(Size.Empty, control.Size);
        Assert.Equal(0, layoutCallCount);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [MemberData(nameof(ControlTests.MinimumSize_Set_TestData), MemberType = typeof(ControlTests))]
    public void TabPage_MinimumSize_Set_GetReturnsExpected(Size value, Size expectedSize, int expectedLayoutCallCount)
    {
        using TabPage control = new()
        {
            Size = Size.Empty
        };
        int layoutCallCount = 0;
        control.Layout += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(control, e.AffectedControl);
            Assert.Equal("Bounds", e.AffectedProperty);
            layoutCallCount++;
        };

        control.MinimumSize = value;
        Assert.Equal(value, control.MinimumSize);
        Assert.Equal(expectedSize, control.Size);
        Assert.Equal(expectedLayoutCallCount, layoutCallCount);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.MinimumSize = value;
        Assert.Equal(value, control.MinimumSize);
        Assert.Equal(expectedSize, control.Size);
        Assert.Equal(expectedLayoutCallCount, layoutCallCount);
        Assert.False(control.IsHandleCreated);
    }

    public static IEnumerable<object[]> Parent_Set_TestData()
    {
        yield return new object[] { null };
        yield return new object[] { new TabControl() };
    }

    [WinFormsTheory]
    [MemberData(nameof(Parent_Set_TestData))]
    public void TabPage_Parent_Set_GetReturnsExpected(Control value)
    {
        using TabPage control = new()
        {
            Parent = value
        };
        Assert.Same(value, control.Parent);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.Parent = value;
        Assert.Same(value, control.Parent);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [MemberData(nameof(Parent_Set_TestData))]
    public void TabPage_Parent_SetWithNonNullOldParent_GetReturnsExpected(Control value)
    {
        using TabControl oldParent = new();
        using TabPage control = new()
        {
            Parent = oldParent
        };

        control.Parent = value;
        Assert.Same(value, control.Parent);
        Assert.Empty(oldParent.Controls);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.Parent = value;
        Assert.Same(value, control.Parent);
        Assert.Empty(oldParent.Controls);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsFact]
    public void TabPage_Parent_SetNonNull_AddsToControls()
    {
        using TabControl parent = new();
        using TabPage control = new()
        {
            Parent = parent
        };
        Assert.Same(parent, control.Parent);
        Assert.Same(control, Assert.Single(parent.Controls));
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.Parent = parent;
        Assert.Same(parent, control.Parent);
        Assert.Same(control, Assert.Single(parent.Controls));
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [MemberData(nameof(Parent_Set_TestData))]
    public void TabPage_Parent_SetWithHandle_GetReturnsExpected(Control value)
    {
        using TabPage control = new();
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        control.Parent = value;
        Assert.Same(value, control.Parent);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set same.
        control.Parent = value;
        Assert.Same(value, control.Parent);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsFact]
    public void TabPage_Parent_SetWithHandler_CallsParentChanged()
    {
        using TabControl parent = new();
        using TabPage control = new();
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            callCount++;
        };
        control.ParentChanged += handler;

        // Set different.
        control.Parent = parent;
        Assert.Same(parent, control.Parent);
        Assert.Equal(1, callCount);

        // Set same.
        control.Parent = parent;
        Assert.Same(parent, control.Parent);
        Assert.Equal(1, callCount);

        // Set null.
        control.Parent = null;
        Assert.Null(control.Parent);
        Assert.Equal(2, callCount);

        // Remove handler.
        control.ParentChanged -= handler;
        control.Parent = parent;
        Assert.Same(parent, control.Parent);
        Assert.Equal(2, callCount);
    }

    [WinFormsFact]
    public void TabPage_Parent_SetSame_ThrowsArgumentException()
    {
        using TabPage control = new();
        Assert.Throws<ArgumentException>(() => control.Parent = control);
        Assert.Null(control.Parent);
    }

    [WinFormsFact]
    public void TabPage_Parent_SetNonTabControl_ThrowsArgumentException()
    {
        using Control parent = new();
        using TabPage control = new();
        Assert.Throws<ArgumentException>(() => control.Parent = parent);
        Assert.Null(control.Parent);
    }

    [WinFormsTheory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public void TabPage_TabIndex_Set_GetReturnsExpected(int value)
    {
        using TabPage control = new()
        {
            TabIndex = value
        };
        Assert.Equal(value, control.TabIndex);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.TabIndex = value;
        Assert.Equal(value, control.TabIndex);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsFact]
    public void TabPage_TabIndex_SetWithHandler_CallsTabIndexChanged()
    {
        using TabPage control = new()
        {
            TabIndex = 0
        };
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            callCount++;
        };
        control.TabIndexChanged += handler;

        // Set different.
        control.TabIndex = 1;
        Assert.Equal(1, control.TabIndex);
        Assert.Equal(1, callCount);

        // Set same.
        control.TabIndex = 1;
        Assert.Equal(1, control.TabIndex);
        Assert.Equal(1, callCount);

        // Set different.
        control.TabIndex = 2;
        Assert.Equal(2, control.TabIndex);
        Assert.Equal(2, callCount);

        // Remove handler.
        control.TabIndexChanged -= handler;
        control.TabIndex = 1;
        Assert.Equal(1, control.TabIndex);
        Assert.Equal(2, callCount);
    }

    [WinFormsFact]
    public void TabPage_TabIndex_SetNegative_CallsArgumentOutOfRangeException()
    {
        using TabPage control = new();
        Assert.Throws<ArgumentOutOfRangeException>("value", () => control.TabIndex = -1);
    }

    [WinFormsTheory]
    [BoolData]
    public void TabPage_TabStop_Set_GetReturnsExpected(bool value)
    {
        using TabPage control = new()
        {
            TabStop = value
        };
        Assert.Equal(value, control.TabStop);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.TabStop = value;
        Assert.Equal(value, control.TabStop);
        Assert.False(control.IsHandleCreated);

        // Set different.
        control.TabStop = value;
        Assert.Equal(value, control.TabStop);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [BoolData]
    public void TabPage_TabStop_SetWithHandle_GetReturnsExpected(bool value)
    {
        using TabPage control = new();
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        control.TabStop = value;
        Assert.Equal(value, control.TabStop);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set same.
        control.TabStop = value;
        Assert.Equal(value, control.TabStop);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set different.
        control.TabStop = value;
        Assert.Equal(value, control.TabStop);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsFact]
    public void TabPage_TabStop_SetWithHandler_CallsTabStopChanged()
    {
        using TabPage control = new()
        {
            TabStop = true
        };
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            callCount++;
        };
        control.TabStopChanged += handler;

        // Set different.
        control.TabStop = false;
        Assert.False(control.TabStop);
        Assert.Equal(1, callCount);

        // Set same.
        control.TabStop = false;
        Assert.False(control.TabStop);
        Assert.Equal(1, callCount);

        // Set different.
        control.TabStop = true;
        Assert.True(control.TabStop);
        Assert.Equal(2, callCount);

        // Remove handler.
        control.TabStopChanged -= handler;
        control.TabStop = false;
        Assert.False(control.TabStop);
        Assert.Equal(2, callCount);
    }

    [WinFormsTheory]
    [NormalizedStringData]
    public void TabPage_Text_Set_GetReturnsExpected(string value, string expected)
    {
        using TabPage control = new()
        {
            Text = value
        };
        Assert.Equal(expected, control.Text);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.Text = value;
        Assert.Equal(expected, control.Text);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [NormalizedStringData]
    public void TabPage_Text_SetWithParent_GetReturnsExpected(string value, string expected)
    {
        using TabControl parent = new();
        using TabPage control = new()
        {
            Parent = parent,
            Text = value
        };
        Assert.Equal(expected, control.Text);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);

        // Set same.
        control.Text = value;
        Assert.Equal(expected, control.Text);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);
    }

    [WinFormsTheory]
    [NormalizedStringData]
    public void TabPage_Text_SetWithDesignModeParent_GetReturnsExpected(string value, string expected)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl parent = new()
        {
            Site = mockSite.Object
        };
        using TabPage control = new()
        {
            Parent = parent,
            Text = value
        };
        Assert.Equal(expected, control.Text);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);

        // Set same.
        control.Text = value;
        Assert.Equal(expected, control.Text);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);
    }

    [WinFormsTheory]
    [NormalizedStringData]
    public void TabPage_Text_SetWithHandle_GetReturnsExpected(string value, string expected)
    {
        using TabPage control = new();
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        control.Text = value;
        Assert.Equal(expected, control.Text);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set same.
        control.Text = value;
        Assert.Equal(expected, control.Text);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsTheory]
    [NormalizedStringData]
    public void TabPage_Text_SetWithParentWithHandle_GetReturnsExpected(string value, string expected)
    {
        using TabControl parent = new();
        using TabPage control = new()
        {
            Parent = parent
        };
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;

        control.Text = value;
        Assert.Equal(expected, control.Text);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(1, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);

        // Set same.
        control.Text = value;
        Assert.Equal(expected, control.Text);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(2, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);
    }

    [WinFormsTheory]
    [NormalizedStringData]
    public void TabPage_Text_SetWithDesignModeParentWithHandle_GetReturnsExpected(string value, string expected)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl parent = new()
        {
            Site = mockSite.Object
        };
        using TabPage control = new()
        {
            Parent = parent
        };
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;

        control.Text = value;
        Assert.Equal(expected, control.Text);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(1, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);

        // Set same.
        control.Text = value;
        Assert.Equal(expected, control.Text);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(2, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);
    }

    [WinFormsTheory]
    [InlineData("Text", "Text")]
    [InlineData("&&Text", "&&Text")]
    [InlineData("&", "&&")]
    [InlineData("&Text", "&&Text")]
    public unsafe void TabPageCollection_Text_SetGetItemsWithHandle_Success(string text, string expectedText)
    {
        using TabControl owner = new();
        using TabPage page1 = new();
        using TabPage page2 = new()
        {
            ImageIndex = 1
        };
        using NullTextTabPage page3 = new();
        owner.TabPages.Add(page1);
        owner.TabPages.Add(page2);
        owner.TabPages.Add(page3);
        Assert.NotEqual(IntPtr.Zero, owner.Handle);

        page2.Text = text;
        Assert.Equal(3, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMCOUNT));

        char* buffer = stackalloc char[256];
        TCITEMW item = default;
        item.cchTextMax = int.MaxValue;
        item.pszText = buffer;
        item.dwStateMask = (TAB_CONTROL_ITEM_STATE)uint.MaxValue;
        item.mask = (TCITEMHEADERA_MASK)uint.MaxValue;

        // Get item 0.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 0, ref item));
        Assert.Equal(TAB_CONTROL_ITEM_STATE.TCIS_BUTTONPRESSED, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);

        // Get item 1.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 1, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Equal(expectedText, new string(item.pszText));
        Assert.Equal(1, item.iImage);

        // Get item 2.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 2, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);
    }

    [WinFormsTheory]
    [InlineData("Text", "Text")]
    [InlineData("&&Text", "&&Text")]
    [InlineData("&", "&&")]
    [InlineData("&Text", "&&Text")]
    public unsafe void TabPageCollection_Text_SetGetItemsWithHandleDesignMode_Success(string text, string expectedText)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl owner = new()
        {
            Site = mockSite.Object
        };
        using TabPage page1 = new();
        using TabPage page2 = new()
        {
            ImageIndex = 1
        };
        using NullTextTabPage page3 = new();
        owner.TabPages.Add(page1);
        owner.TabPages.Add(page2);
        owner.TabPages.Add(page3);
        Assert.NotEqual(IntPtr.Zero, owner.Handle);

        page2.Text = text;
        Assert.Equal(3, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMCOUNT));

        char* buffer = stackalloc char[256];
        TCITEMW item = default;
        item.cchTextMax = int.MaxValue;
        item.pszText = buffer;
        item.dwStateMask = (TAB_CONTROL_ITEM_STATE)uint.MaxValue;
        item.mask = (TCITEMHEADERA_MASK)uint.MaxValue;

        // Get item 0.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 0, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);

        // Get item 1.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 1, ref item));
        Assert.Equal(TAB_CONTROL_ITEM_STATE.TCIS_BUTTONPRESSED, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Equal(expectedText, new string(item.pszText));
        Assert.Equal(1, item.iImage);

        // Get item 2.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 2, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);
    }

    [WinFormsFact]
    public void TabPage_Text_SetWithHandler_CallsTextChanged()
    {
        using TabPage control = new();
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Equal(EventArgs.Empty, e);
            callCount++;
        };
        control.TextChanged += handler;

        // Set different.
        control.Text = "text";
        Assert.Equal("text", control.Text);
        Assert.Equal(1, callCount);

        // Set same.
        control.Text = "text";
        Assert.Equal("text", control.Text);
        Assert.Equal(1, callCount);

        // Set different.
        control.Text = null;
        Assert.Empty(control.Text);
        Assert.Equal(2, callCount);

        // Remove handler.
        control.TextChanged -= handler;
        control.Text = "text";
        Assert.Equal("text", control.Text);
        Assert.Equal(2, callCount);
    }

    [WinFormsTheory]
    [NormalizedStringData]
    public void TabPage_ToolTipText_Set_GetReturnsExpected(string value, string expected)
    {
        using TabPage control = new()
        {
            ToolTipText = value
        };
        Assert.Equal(expected, control.ToolTipText);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.ToolTipText = value;
        Assert.Equal(expected, control.ToolTipText);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [NormalizedStringData]
    public void TabPage_ToolTipText_SetWithParent_GetReturnsExpected(string value, string expected)
    {
        using TabControl parent = new();
        using TabPage control = new()
        {
            Parent = parent,
            ToolTipText = value
        };
        Assert.Equal(expected, control.ToolTipText);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);

        // Set same.
        control.ToolTipText = value;
        Assert.Equal(expected, control.ToolTipText);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);
    }

    [WinFormsTheory]
    [NormalizedStringData]
    public void TabPage_ToolTipText_SetWithDesignModeParent_GetReturnsExpected(string value, string expected)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl parent = new()
        {
            Site = mockSite.Object
        };
        using TabPage control = new()
        {
            Parent = parent,
            ToolTipText = value
        };
        Assert.Equal(expected, control.ToolTipText);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);

        // Set same.
        control.ToolTipText = value;
        Assert.Equal(expected, control.ToolTipText);
        Assert.False(control.Visible);
        Assert.False(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);
    }

    [WinFormsTheory]
    [NormalizedStringData]
    public void TabPage_ToolTipText_SetWithHandle_GetReturnsExpected(string value, string expected)
    {
        using TabPage control = new();
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        control.ToolTipText = value;
        Assert.Equal(expected, control.ToolTipText);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set same.
        control.ToolTipText = value;
        Assert.Equal(expected, control.ToolTipText);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsTheory]
    [InlineData(null, "", 0)]
    [InlineData("", "", 0)]
    [InlineData("text", "text", 1)]
    public void TabPage_ToolTipText_SetWithParentWithHandle_GetReturnsExpected(string value, string expected, int expectedInvalidateCallCount)
    {
        using TabControl parent = new();
        using TabPage control = new()
        {
            Parent = parent
        };
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;

        control.ToolTipText = value;
        Assert.Equal(expected, control.ToolTipText);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidateCallCount, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);

        // Set same.
        control.ToolTipText = value;
        Assert.Equal(expected, control.ToolTipText);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidateCallCount, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);
    }

    [WinFormsTheory]
    [InlineData(null, "", 0)]
    [InlineData("", "", 0)]
    [InlineData("text", "text", 1)]
    public void TabPage_ToolTipText_SetWithDesignModeParentWithHandle_GetReturnsExpected(string value, string expected, int expectedInvalidateCallCount)
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl parent = new()
        {
            Site = mockSite.Object
        };
        using TabPage control = new()
        {
            Parent = parent
        };
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;

        control.ToolTipText = value;
        Assert.Equal(expected, control.ToolTipText);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidateCallCount, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);

        // Set same.
        control.ToolTipText = value;
        Assert.Equal(expected, control.ToolTipText);
        Assert.True(control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidateCallCount, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);
    }

    [WinFormsFact]
    public unsafe void TabPageCollection_ToolTipText_SetGetItemsWithHandle_Success()
    {
        using TabControl owner = new();
        using TabPage page1 = new();
        using TabPage page2 = new()
        {
            Text = "Text",
            ImageIndex = 1
        };
        using NullTextTabPage page3 = new();
        owner.TabPages.Add(page1);
        owner.TabPages.Add(page2);
        owner.TabPages.Add(page3);
        Assert.NotEqual(IntPtr.Zero, owner.Handle);

        page2.ToolTipText = "ToolTipText";
        Assert.Equal(3, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMCOUNT));

        char* buffer = stackalloc char[256];
        TCITEMW item = default;
        item.cchTextMax = int.MaxValue;
        item.pszText = buffer;
        item.dwStateMask = (TAB_CONTROL_ITEM_STATE)uint.MaxValue;
        item.mask = (TCITEMHEADERA_MASK)uint.MaxValue;

        // Get item 0.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 0, ref item));
        Assert.Equal(TAB_CONTROL_ITEM_STATE.TCIS_BUTTONPRESSED, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);

        // Get item 1.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 1, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Equal("Text", new string(item.pszText));
        Assert.Equal(1, item.iImage);

        // Get item 2.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 2, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);
    }

    [WinFormsFact]
    public unsafe void TabPageCollection_ToolTipText_SetGetItemsWithHandleDesignMode_Success()
    {
        Mock<ISite> mockSite = new(MockBehavior.Strict);
        mockSite
            .Setup(s => s.GetService(typeof(AmbientProperties)))
            .Returns(null);
        mockSite
            .Setup(s => s.DesignMode)
            .Returns(true);
        mockSite
            .Setup(s => s.Container)
            .Returns((IContainer)null);
        using TabControl owner = new()
        {
            Site = mockSite.Object
        };
        using TabPage page1 = new();
        using TabPage page2 = new()
        {
            Text = "Text",
            ImageIndex = 1
        };
        using NullTextTabPage page3 = new();
        owner.TabPages.Add(page1);
        owner.TabPages.Add(page2);
        owner.TabPages.Add(page3);
        Assert.NotEqual(IntPtr.Zero, owner.Handle);

        page2.ToolTipText = "ToolTipText";
        Assert.Equal(3, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMCOUNT));

        char* buffer = stackalloc char[256];
        TCITEMW item = default;
        item.cchTextMax = int.MaxValue;
        item.pszText = buffer;
        item.dwStateMask = (TAB_CONTROL_ITEM_STATE)uint.MaxValue;
        item.mask = (TCITEMHEADERA_MASK)uint.MaxValue;

        // Get item 0.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 0, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);

        // Get item 1.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 1, ref item));
        Assert.Equal(TAB_CONTROL_ITEM_STATE.TCIS_BUTTONPRESSED, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Equal("Text", new string(item.pszText));
        Assert.Equal(1, item.iImage);

        // Get item 2.
        Assert.Equal(1, (int)PInvokeCore.SendMessage(owner, PInvoke.TCM_GETITEMW, 2, ref item));
        Assert.Equal((TAB_CONTROL_ITEM_STATE)0, item.dwState);
        Assert.Equal(IntPtr.Zero, (nint)item.lParam);
        Assert.Equal(int.MaxValue, item.cchTextMax);
        Assert.Empty(new string(item.pszText));
        Assert.Equal(-1, item.iImage);
    }

    [WinFormsTheory]
    [BoolData]
    public void TabPage_UseVisualStyleBackColor_Set_GetReturnsExpected(bool value)
    {
        using TabPage control = new()
        {
            UseVisualStyleBackColor = value
        };
        Assert.Equal(value, control.UseVisualStyleBackColor);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.UseVisualStyleBackColor = value;
        Assert.Equal(value, control.UseVisualStyleBackColor);
        Assert.False(control.IsHandleCreated);

        // Set different.
        control.UseVisualStyleBackColor = !value;
        Assert.Equal(!value, control.UseVisualStyleBackColor);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [InlineData(true, 1)]
    [InlineData(false, 0)]
    public void TabPage_UseVisualStyleBackColor_SetWithHandle_GetReturnsExpected(bool value, int expectedInvalidatedCallCount)
    {
        using TabPage control = new();
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        control.UseVisualStyleBackColor = value;
        Assert.Equal(value, control.UseVisualStyleBackColor);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set same.
        control.UseVisualStyleBackColor = value;
        Assert.Equal(value, control.UseVisualStyleBackColor);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set different.
        control.UseVisualStyleBackColor = !value;
        Assert.Equal(!value, control.UseVisualStyleBackColor);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidatedCallCount + 1, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsTheory]
    [BoolData]
    public void TabPage_Visible_Set_GetReturnsExpected(bool value)
    {
        using TabPage control = new()
        {
            Visible = value
        };
        Assert.Equal(value, control.Visible);
        Assert.False(control.IsHandleCreated);

        // Set same.
        control.Visible = value;
        Assert.Equal(value, control.Visible);
        Assert.False(control.IsHandleCreated);

        // Set different.
        control.Visible = !value;
        Assert.Equal(!value, control.Visible);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [BoolData]
    public void TabPage_Visible_SetWithParent_GetReturnsExpected(bool value)
    {
        using TabControl parent = new();
        using TabPage control = new()
        {
            Parent = parent,
            Visible = value
        };
        Assert.Equal(value, control.Visible);
        Assert.Equal(value, control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);

        // Set same.
        control.Visible = value;
        Assert.Equal(value, control.Visible);
        Assert.Equal(value, control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);

        // Set different.
        control.Visible = !value;
        Assert.Equal(!value, control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.False(parent.IsHandleCreated);
    }

    public static IEnumerable<object[]> Visible_SetWithHandle_TestData()
    {
        foreach (bool userPaint in new bool[] { true, false })
        {
            yield return new object[] { userPaint, true };
            yield return new object[] { userPaint, false };
        }
    }

    [WinFormsTheory]
    [MemberData(nameof(Visible_SetWithHandle_TestData))]
    public void TabPage_Visible_SetWithHandle_GetReturnsExpected(bool userPaint, bool value)
    {
        using SubTabPage control = new();
        control.SetStyle(ControlStyles.UserPaint, userPaint);
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        control.Visible = value;
        Assert.Equal(value, control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set same.
        control.Visible = value;
        Assert.Equal(value, control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Set different.
        control.Visible = !value;
        Assert.Equal(!value, control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsTheory]
    [BoolData]
    public void TabPage_Visible_SetWithParentWithHandle_GetReturnsExpected(bool value)
    {
        using TabControl parent = new();
        using TabPage control = new()
        {
            Parent = parent
        };
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;

        control.Visible = value;
        Assert.Equal(value, control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);

        // Set same.
        control.Visible = value;
        Assert.Equal(value, control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);

        // Set different.
        control.Visible = !value;
        Assert.Equal(!value, control.Visible);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
        Assert.True(parent.IsHandleCreated);
        Assert.Equal(0, parentInvalidatedCallCount);
        Assert.Equal(0, parentStyleChangedCallCount);
        Assert.Equal(0, parentCreatedCallCount);
    }

    [WinFormsFact]
    public void TabPage_Visible_SetWithHandler_CallsVisibleChanged()
    {
        using TabPage control = new()
        {
            Visible = true
        };
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            callCount++;
        };
        control.VisibleChanged += handler;

        // Set different.
        control.Visible = false;
        Assert.False(control.Visible);
        Assert.Equal(1, callCount);

        // Set same.
        control.Visible = false;
        Assert.False(control.Visible);
        Assert.Equal(1, callCount);

        // Set different.
        control.Visible = true;
        Assert.True(control.Visible);
        Assert.Equal(2, callCount);

        // Remove handler.
        control.VisibleChanged -= handler;
        control.Visible = false;
        Assert.False(control.Visible);
        Assert.Equal(2, callCount);
    }

    [WinFormsFact]
    public void TabPage_CreateControlsInstance_Invoke_ReturnsExpected()
    {
        using SubTabPage control = new();
        Control.ControlCollection controls = Assert.IsType<TabPage.TabPageControlCollection>(control.CreateControlsInstance());
        Assert.Empty(controls);
        Assert.Same(control, controls.Owner);
        Assert.False(controls.IsReadOnly);
        Assert.NotSame(controls, control.CreateControlsInstance());
    }

    [WinFormsFact]
    public void TabPage_GetAutoSizeMode_Invoke_ReturnsExpected()
    {
        using SubTabPage control = new();
        Assert.Equal(AutoSizeMode.GrowOnly, control.GetAutoSizeMode());
    }

    [WinFormsTheory]
    [InlineData(0, true)]
    [InlineData(SubTabPage.ScrollStateAutoScrolling, false)]
    [InlineData(SubTabPage.ScrollStateFullDrag, false)]
    [InlineData(SubTabPage.ScrollStateHScrollVisible, false)]
    [InlineData(SubTabPage.ScrollStateUserHasScrolled, false)]
    [InlineData(SubTabPage.ScrollStateVScrollVisible, false)]
    [InlineData(int.MaxValue, false)]
    [InlineData((-1), false)]
    public void TabPage_GetScrollState_Invoke_ReturnsExpected(int bit, bool expected)
    {
        using SubTabPage control = new();
        Assert.Equal(expected, control.GetScrollState(bit));
    }

    [WinFormsTheory]
    [InlineData(ControlStyles.ContainerControl, true)]
    [InlineData(ControlStyles.UserPaint, true)]
    [InlineData(ControlStyles.Opaque, false)]
    [InlineData(ControlStyles.ResizeRedraw, false)]
    [InlineData(ControlStyles.FixedWidth, false)]
    [InlineData(ControlStyles.FixedHeight, false)]
    [InlineData(ControlStyles.StandardClick, true)]
    [InlineData(ControlStyles.Selectable, false)]
    [InlineData(ControlStyles.UserMouse, false)]
    [InlineData(ControlStyles.SupportsTransparentBackColor, true)]
    [InlineData(ControlStyles.StandardDoubleClick, true)]
    [InlineData(ControlStyles.AllPaintingInWmPaint, false)]
    [InlineData(ControlStyles.CacheText, true)]
    [InlineData(ControlStyles.EnableNotifyMessage, false)]
    [InlineData(ControlStyles.DoubleBuffer, false)]
    [InlineData(ControlStyles.OptimizedDoubleBuffer, false)]
    [InlineData(ControlStyles.UseTextForAccessibility, true)]
    [InlineData((ControlStyles)0, true)]
    [InlineData((ControlStyles)int.MaxValue, false)]
    [InlineData((ControlStyles)(-1), false)]
    public void TabPage_GetStyle_Invoke_ReturnsExpected(ControlStyles flag, bool expected)
    {
        using SubTabPage control = new();
        Assert.Equal(expected, control.GetStyle(flag));

        // Call again to test caching.
        Assert.Equal(expected, control.GetStyle(flag));
    }

    [WinFormsFact]
    public void TabPage_GetTopLevel_Invoke_ReturnsExpected()
    {
        using SubTabPage control = new();
        Assert.False(control.GetTopLevel());
    }

    [WinFormsFact]
    public void TabPage_GetTabPageOfComponent_InvokeTabPageInHierarchy_ReturnsExpected()
    {
        using TabPage grandparent = new();
        using Control parent = new()
        {
            Parent = grandparent
        };
        using Control control = new()
        {
            Parent = parent
        };
        Assert.Same(grandparent, TabPage.GetTabPageOfComponent(control));
        Assert.Same(grandparent, TabPage.GetTabPageOfComponent(parent));
        Assert.Same(grandparent, TabPage.GetTabPageOfComponent(grandparent));
    }

    [WinFormsFact]
    public void TabPage_GetTabPageOfComponent_InvokeNoTabPageInHierarchy_ReturnsNull()
    {
        using Control grandparent = new();
        using Control parent = new()
        {
            Parent = grandparent
        };
        using Control control = new()
        {
            Parent = parent
        };
        Assert.Null(TabPage.GetTabPageOfComponent(control));
        Assert.Null(TabPage.GetTabPageOfComponent(parent));
        Assert.Null(TabPage.GetTabPageOfComponent(grandparent));
    }

    [WinFormsTheory]
    [InlineData(null)]
    [InlineData("NotAControl")]
    public void TabPage_GetTabPageOfComponent_InvokeInvalidControl_ReturnsNull(object comp)
    {
        Assert.Null(TabPage.GetTabPageOfComponent(comp));
    }

    [WinFormsTheory]
    [NewAndDefaultData<EventArgs>]
    public void TabPage_OnEnter_Invoke_DoesNotCallEnter(EventArgs eventArgs)
    {
        using SubTabPage control = new();
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(eventArgs, e);
            callCount++;
        };

        // Call with handler.
        control.Enter += handler;
        control.OnEnter(eventArgs);
        Assert.Equal(0, callCount);

        // Remove handler.
        control.Enter -= handler;
        control.OnEnter(eventArgs);
        Assert.Equal(0, callCount);
    }

    [WinFormsTheory]
    [NewAndDefaultData<EventArgs>]
    public void TabPage_OnEnter_InvokeWithParent_DoesNotCallEnter(EventArgs eventArgs)
    {
        using TabControl parent = new();
        using SubTabPage control = new()
        {
            Parent = parent
        };
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(eventArgs, e);
            callCount++;
        };

        // Call with handler.
        control.Enter += handler;
        control.OnEnter(eventArgs);
        Assert.Equal(0, callCount);

        // Remove handler.
        control.Enter -= handler;
        control.OnEnter(eventArgs);
        Assert.Equal(0, callCount);
    }

    [WinFormsTheory]
    [NewAndDefaultData<EventArgs>]
    public void TabPage_OnLeave_Invoke_DoesNotCallLeave(EventArgs eventArgs)
    {
        using SubTabPage control = new();
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(eventArgs, e);
            callCount++;
        };

        // Call with handler.
        control.Leave += handler;
        control.OnLeave(eventArgs);
        Assert.Equal(0, callCount);

        // Remove handler.
        control.Leave -= handler;
        control.OnLeave(eventArgs);
        Assert.Equal(0, callCount);
    }

    [WinFormsTheory]
    [NewAndDefaultData<EventArgs>]
    public void TabPage_OnLeave_InvokeWithParent_DoesNotCallLeave(EventArgs eventArgs)
    {
        using TabControl parent = new();
        using SubTabPage control = new()
        {
            Parent = parent
        };
        int callCount = 0;
        EventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(eventArgs, e);
            callCount++;
        };

        // Call with handler.
        control.Leave += handler;
        control.OnLeave(eventArgs);
        Assert.Equal(0, callCount);

        // Remove handler.
        control.Leave -= handler;
        control.OnLeave(eventArgs);
        Assert.Equal(0, callCount);
    }

    public static IEnumerable<object[]> OnPaintBackground_TestData()
    {
        foreach (Image backgroundImage in new Image[] { null, new Bitmap(10, 10, PixelFormat.Format32bppRgb), new Bitmap(10, 10, PixelFormat.Format32bppArgb) })
        {
            foreach (ImageLayout backgroundImageLayout in Enum.GetValues(typeof(ImageLayout)))
            {
                yield return new object[] { true, Color.Empty, backgroundImage, backgroundImageLayout };
                yield return new object[] { true, Color.Red, backgroundImage, backgroundImageLayout };
                yield return new object[] { true, Color.FromArgb(100, 50, 100, 150), backgroundImage, backgroundImageLayout };
                yield return new object[] { true, Color.FromArgb(0, 50, 100, 150), backgroundImage, backgroundImageLayout };
                yield return new object[] { false, Color.Empty, backgroundImage, backgroundImageLayout };
                yield return new object[] { false, Color.Red, backgroundImage, backgroundImageLayout };
            }
        }
    }

    [WinFormsTheory]
    [MemberData(nameof(OnPaintBackground_TestData))]
    public void TabPage_OnPaintBackground_Invoke_Success(bool supportsTransparentBackColor, Color backColor, Image backgroundImage, ImageLayout backgroundImageLayout)
    {
        using Bitmap image = new(10, 10);
        using Graphics graphics = Graphics.FromImage(image);
        using PaintEventArgs eventArgs = new(graphics, new Rectangle(1, 2, 3, 4));

        using SubTabPage control = new();
        control.SetStyle(ControlStyles.SupportsTransparentBackColor, supportsTransparentBackColor);
        control.BackColor = backColor;
        control.BackgroundImage = backgroundImage;
        control.BackgroundImageLayout = backgroundImageLayout;
        int callCount = 0;
        PaintEventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(eventArgs, e);
            callCount++;
        };

        // Call with handler.
        control.Paint += handler;
        control.OnPaintBackground(eventArgs);
        Assert.Equal(0, callCount);
        Assert.False(control.IsHandleCreated);

        // Remove handler.
        control.Paint -= handler;
        control.OnPaintBackground(eventArgs);
        Assert.Equal(0, callCount);
        Assert.False(control.IsHandleCreated);
    }

    public static IEnumerable<object[]> OnPaintBackground_WithParent_TestData()
    {
        foreach (TabAppearance appearance in Enum.GetValues(typeof(TabAppearance)))
        {
            foreach (bool useVisualStyleBackColor in new bool[] { true, false })
            {
                foreach (Image backgroundImage in new Image[] { null, new Bitmap(10, 10, PixelFormat.Format32bppRgb) })
                {
                    foreach (ImageLayout backgroundImageLayout in Enum.GetValues(typeof(ImageLayout)))
                    {
                        yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Empty, backgroundImage, backgroundImageLayout, 0 };
                        yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Red, backgroundImage, backgroundImageLayout, 0 };
                        yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(100, 50, 100, 150), backgroundImage, backgroundImageLayout, 1 };
                        yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(0, 50, 100, 150), backgroundImage, backgroundImageLayout, 1 };
                        yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Empty, backgroundImage, backgroundImageLayout, 0 };
                        yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Red, backgroundImage, backgroundImageLayout, 0 };
                    }
                }

                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Empty, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 0 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Red, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 0 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(100, 50, 100, 150), new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(0, 50, 100, 150), new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Empty, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 0 };
                yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Red, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 0 };

                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Empty, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Red, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(100, 50, 100, 150), new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(0, 50, 100, 150), new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Empty, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Red, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
            }
        }
    }

    [WinFormsTheory]
    [MemberData(nameof(OnPaintBackground_WithParent_TestData))]
    public void TabPage_OnPaintBackground_InvokeWithParent_CallsPaint(TabAppearance appearance, bool useVisualStyleBackColor, bool supportsTransparentBackColor, Color backColor, Image backgroundImage, ImageLayout backgroundImageLayout, int expectedPaintCallCount)
    {
        using Bitmap image = new(10, 10);
        using Graphics graphics = Graphics.FromImage(image);
        using PaintEventArgs eventArgs = new(graphics, new Rectangle(1, 2, 3, 4));

        using TabControl parent = new()
        {
            Bounds = new Rectangle(1, 2, 30, 40),
            Appearance = appearance
        };
        using SubTabPage control = new()
        {
            Bounds = new Rectangle(1, 2, 10, 20),
            Parent = parent,
            UseVisualStyleBackColor = useVisualStyleBackColor
        };
        control.SetStyle(ControlStyles.SupportsTransparentBackColor, supportsTransparentBackColor);
        control.BackColor = backColor;
        control.BackgroundImage = backgroundImage;
        control.BackgroundImageLayout = backgroundImageLayout;
        int callCount = 0;
        PaintEventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(eventArgs, e);
            callCount++;
        };
        int parentCallCount = 0;
        PaintEventHandler parentHandler = (sender, e) =>
        {
            Assert.Same(parent, sender);
            Assert.NotSame(graphics, e.Graphics);
            Assert.Equal(new Rectangle(1, 2, 0, 0), e.ClipRectangle);
            parentCallCount++;
        };

        // Call with handler.
        control.Paint += handler;
        parent.Paint += parentHandler;
        control.OnPaintBackground(eventArgs);
        Assert.Equal(0, callCount);
        Assert.Equal(expectedPaintCallCount, parentCallCount);
        Assert.False(control.IsHandleCreated);

        // Remove handler.
        control.Paint -= handler;
        parent.Paint -= parentHandler;
        control.OnPaintBackground(eventArgs);
        Assert.Equal(0, callCount);
        Assert.Equal(expectedPaintCallCount, parentCallCount);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [MemberData(nameof(OnPaintBackground_TestData))]
    public void TabPage_OnPaintBackground_InvokeWithHandle_Success(bool supportsTransparentBackColor, Color backColor, Image backgroundImage, ImageLayout backgroundImageLayout)
    {
        using Bitmap image = new(10, 10);
        using Graphics graphics = Graphics.FromImage(image);
        using PaintEventArgs eventArgs = new(graphics, new Rectangle(1, 2, 3, 4));

        using SubTabPage control = new();
        control.SetStyle(ControlStyles.SupportsTransparentBackColor, supportsTransparentBackColor);
        control.BackColor = backColor;
        control.BackgroundImage = backgroundImage;
        control.BackgroundImageLayout = backgroundImageLayout;
        int callCount = 0;
        PaintEventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(eventArgs, e);
            callCount++;
        };
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        // Call with handler.
        control.Paint += handler;
        control.OnPaintBackground(eventArgs);
        Assert.Equal(0, callCount);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Remove handler.
        control.Paint -= handler;
        control.OnPaintBackground(eventArgs);
        Assert.Equal(0, callCount);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    public static IEnumerable<object[]> OnPaintBackground_WithParentWithHandle_TestData()
    {
        foreach (TabAppearance appearance in Enum.GetValues(typeof(TabAppearance)))
        {
            foreach (bool useVisualStyleBackColor in new bool[] { true, false })
            {
                foreach (Image backgroundImage in new Image[] { null, new Bitmap(10, 10, PixelFormat.Format32bppRgb) })
                {
                    foreach (ImageLayout backgroundImageLayout in Enum.GetValues(typeof(ImageLayout)))
                    {
                        yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Empty, backgroundImage, backgroundImageLayout, 0 };
                        yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Red, backgroundImage, backgroundImageLayout, 0 };
                        yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(100, 50, 100, 150), backgroundImage, backgroundImageLayout, 1 };
                        yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(0, 50, 100, 150), backgroundImage, backgroundImageLayout, 1 };
                        yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Empty, backgroundImage, backgroundImageLayout, 0 };
                        yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Red, backgroundImage, backgroundImageLayout, 0 };
                    }
                }

                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Empty, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 0 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Red, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 0 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(100, 50, 100, 150), new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(0, 50, 100, 150), new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Empty, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 0 };
                yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Red, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.None, 0 };

                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Empty, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.Red, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(100, 50, 100, 150), new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, true, Color.FromArgb(0, 50, 100, 150), new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Empty, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
                yield return new object[] { appearance, useVisualStyleBackColor, false, Color.Red, new Bitmap(10, 10, PixelFormat.Format32bppArgb), ImageLayout.Tile, 1 };
            }
        }
    }

    [WinFormsTheory]
    [MemberData(nameof(OnPaintBackground_WithParentWithHandle_TestData))]
    public void TabPage_OnPaintBackground_InvokeWithParentWithHandle_CallsPaint(TabAppearance appearance, bool useVisualStyleBackColor, bool supportsTransparentBackColor, Color backColor, Image backgroundImage, ImageLayout backgroundImageLayout, int expectedPaintCallCount)
    {
        using Bitmap image = new(10, 10);
        using Graphics graphics = Graphics.FromImage(image);
        using PaintEventArgs eventArgs = new(graphics, new Rectangle(1, 2, 3, 4));

        using TabControl parent = new()
        {
            Bounds = new Rectangle(1, 2, 30, 40),
            Appearance = appearance,
        };
        using SubTabPage control = new()
        {
            Bounds = new Rectangle(1, 2, 10, 20),
            Parent = parent,
            UseVisualStyleBackColor = useVisualStyleBackColor
        };
        control.SetStyle(ControlStyles.SupportsTransparentBackColor, supportsTransparentBackColor);
        control.BackColor = backColor;
        control.BackgroundImage = backgroundImage;
        control.BackgroundImageLayout = backgroundImageLayout;
        int callCount = 0;
        PaintEventHandler handler = (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(eventArgs, e);
            callCount++;
        };
        int parentCallCount = 0;
        PaintEventHandler parentHandler = (sender, e) =>
        {
            Assert.Same(parent, sender);
            Assert.NotSame(graphics, e.Graphics);
            Assert.Equal(parent.DisplayRectangle, e.ClipRectangle);
            parentCallCount++;
        };
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        // Call with handler.
        control.Paint += handler;
        parent.Paint += parentHandler;
        control.OnPaintBackground(eventArgs);
        Assert.Equal(0, callCount);
        Assert.Equal(expectedPaintCallCount, parentCallCount);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Remove handler.
        control.Paint -= handler;
        parent.Paint -= parentHandler;
        control.OnPaintBackground(eventArgs);
        Assert.Equal(0, callCount);
        Assert.Equal(expectedPaintCallCount, parentCallCount);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(0, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    [WinFormsFact]
    public void TabPage_OnPaintBackground_NullEventArgs_ThrowsArgumentNullException()
    {
        using SubTabPage control = new();
        Assert.Throws<ArgumentNullException>(() => control.OnPaintBackground(null));
    }

    public static IEnumerable<object[]> SetBoundsCore_TestData()
    {
        foreach (BoundsSpecified specified in Enum.GetValues(typeof(BoundsSpecified)))
        {
            yield return new object[] { 0, 0, 0, 0, specified, 0 };
            yield return new object[] { -1, -2, -3, -4, specified, 1 };
            yield return new object[] { 1, 0, 0, 0, specified, 1 };
            yield return new object[] { 0, 2, 0, 0, specified, 1 };
            yield return new object[] { 1, 2, 0, 0, specified, 1 };
            yield return new object[] { 0, 0, 1, 0, specified, 0 };
            yield return new object[] { 0, 0, 0, 2, specified, 0 };
            yield return new object[] { 0, 0, 1, 2, specified, 0 };
            yield return new object[] { 1, 2, 30, 40, specified, 1 };
        }
    }

    [WinFormsTheory]
    [MemberData(nameof(SetBoundsCore_TestData))]
    public void TabPage_SetBoundsCore_Invoke_Success(int x, int y, int width, int height, BoundsSpecified specified, int expectedLocationChangedCallCount)
    {
        using SubTabPage control = new();
        int moveCallCount = 0;
        int locationChangedCallCount = 0;
        int layoutCallCount = 0;
        int resizeCallCount = 0;
        int sizeChangedCallCount = 0;
        int clientSizeChangedCallCount = 0;
        control.Move += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(locationChangedCallCount, moveCallCount);
            Assert.Equal(layoutCallCount, moveCallCount);
            Assert.Equal(resizeCallCount, moveCallCount);
            Assert.Equal(sizeChangedCallCount, moveCallCount);
            Assert.Equal(clientSizeChangedCallCount, moveCallCount);
            moveCallCount++;
        };
        control.LocationChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(moveCallCount - 1, locationChangedCallCount);
            Assert.Equal(layoutCallCount, locationChangedCallCount);
            Assert.Equal(resizeCallCount, locationChangedCallCount);
            Assert.Equal(sizeChangedCallCount, locationChangedCallCount);
            Assert.Equal(clientSizeChangedCallCount, locationChangedCallCount);
            locationChangedCallCount++;
        };
        control.Layout += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(control, e.AffectedControl);
            Assert.Equal("Bounds", e.AffectedProperty);
            Assert.Equal(resizeCallCount, layoutCallCount);
            Assert.Equal(sizeChangedCallCount, layoutCallCount);
            Assert.Equal(clientSizeChangedCallCount, layoutCallCount);
            layoutCallCount++;
        };
        control.Resize += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(layoutCallCount - 1, resizeCallCount);
            Assert.Equal(sizeChangedCallCount, resizeCallCount);
            Assert.Equal(clientSizeChangedCallCount, resizeCallCount);
            resizeCallCount++;
        };
        control.SizeChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(resizeCallCount - 1, sizeChangedCallCount);
            Assert.Equal(layoutCallCount - 1, sizeChangedCallCount);
            Assert.Equal(clientSizeChangedCallCount, sizeChangedCallCount);
            sizeChangedCallCount++;
        };
        control.ClientSizeChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(resizeCallCount - 1, clientSizeChangedCallCount);
            Assert.Equal(layoutCallCount - 1, clientSizeChangedCallCount);
            Assert.Equal(sizeChangedCallCount - 1, clientSizeChangedCallCount);
            clientSizeChangedCallCount++;
        };

        control.SetBoundsCore(x, y, width, height, specified);
        Assert.Equal(new Size(width, height), control.ClientSize);
        Assert.Equal(new Rectangle(0, 0, width, height), control.ClientRectangle);
        Assert.Equal(new Rectangle(0, 0, width, height), control.DisplayRectangle);
        Assert.Equal(new Size(width, height), control.Size);
        Assert.Equal(x, control.Left);
        Assert.Equal(x + width, control.Right);
        Assert.Equal(y, control.Top);
        Assert.Equal(y + height, control.Bottom);
        Assert.Equal(width, control.Width);
        Assert.Equal(height, control.Height);
        Assert.Equal(new Rectangle(x, y, width, height), control.Bounds);
        Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
        Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
        Assert.Equal(1, layoutCallCount);
        Assert.Equal(1, resizeCallCount);
        Assert.Equal(1, sizeChangedCallCount);
        Assert.Equal(1, clientSizeChangedCallCount);
        Assert.False(control.IsHandleCreated);

        // Call again.
        control.SetBoundsCore(x, y, width, height, specified);
        Assert.Equal(new Size(width, height), control.ClientSize);
        Assert.Equal(new Rectangle(0, 0, width, height), control.ClientRectangle);
        Assert.Equal(new Rectangle(0, 0, width, height), control.DisplayRectangle);
        Assert.Equal(new Size(width, height), control.Size);
        Assert.Equal(x, control.Left);
        Assert.Equal(x + width, control.Right);
        Assert.Equal(y, control.Top);
        Assert.Equal(y + height, control.Bottom);
        Assert.Equal(width, control.Width);
        Assert.Equal(height, control.Height);
        Assert.Equal(new Rectangle(x, y, width, height), control.Bounds);
        Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
        Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
        Assert.Equal(1, layoutCallCount);
        Assert.Equal(1, resizeCallCount);
        Assert.Equal(1, sizeChangedCallCount);
        Assert.Equal(1, clientSizeChangedCallCount);
        Assert.False(control.IsHandleCreated);
    }

    [WinFormsTheory]
    [MemberData(nameof(SetBoundsCore_TestData))]
    public void TabPage_SetBoundsCore_InvokeWithParent_Success(int x, int y, int width, int height, BoundsSpecified specified, int expectedLocationChangedCallCount)
    {
        using TabControl parent = new();
        using SubTabPage control = new()
        {
            Parent = parent
        };
        int moveCallCount = 0;
        int locationChangedCallCount = 0;
        int layoutCallCount = 0;
        int resizeCallCount = 0;
        int sizeChangedCallCount = 0;
        int clientSizeChangedCallCount = 0;
        int parentLayoutCallCount = 0;
        control.Move += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(locationChangedCallCount, moveCallCount);
            Assert.Equal(layoutCallCount, moveCallCount);
            Assert.Equal(resizeCallCount, moveCallCount);
            Assert.Equal(sizeChangedCallCount, moveCallCount);
            Assert.Equal(clientSizeChangedCallCount, moveCallCount);
            moveCallCount++;
        };
        control.LocationChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(moveCallCount - 1, locationChangedCallCount);
            Assert.Equal(layoutCallCount, locationChangedCallCount);
            Assert.Equal(resizeCallCount, locationChangedCallCount);
            Assert.Equal(sizeChangedCallCount, locationChangedCallCount);
            Assert.Equal(clientSizeChangedCallCount, locationChangedCallCount);
            locationChangedCallCount++;
        };
        control.Layout += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(control, e.AffectedControl);
            Assert.Equal("Bounds", e.AffectedProperty);
            Assert.Equal(resizeCallCount, layoutCallCount);
            Assert.Equal(sizeChangedCallCount, layoutCallCount);
            Assert.Equal(clientSizeChangedCallCount, layoutCallCount);
            Assert.Equal(parentLayoutCallCount, layoutCallCount);
            layoutCallCount++;
        };
        control.Resize += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(layoutCallCount - 1, resizeCallCount);
            Assert.Equal(sizeChangedCallCount, resizeCallCount);
            Assert.Equal(clientSizeChangedCallCount, resizeCallCount);
            Assert.Equal(parentLayoutCallCount, resizeCallCount);
            resizeCallCount++;
        };
        control.SizeChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(resizeCallCount - 1, sizeChangedCallCount);
            Assert.Equal(layoutCallCount - 1, sizeChangedCallCount);
            Assert.Equal(clientSizeChangedCallCount, sizeChangedCallCount);
            Assert.Equal(parentLayoutCallCount, sizeChangedCallCount);
            sizeChangedCallCount++;
        };
        control.ClientSizeChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(resizeCallCount - 1, clientSizeChangedCallCount);
            Assert.Equal(layoutCallCount - 1, clientSizeChangedCallCount);
            Assert.Equal(sizeChangedCallCount - 1, clientSizeChangedCallCount);
            Assert.Equal(parentLayoutCallCount, clientSizeChangedCallCount);
            clientSizeChangedCallCount++;
        };
        void parentHandler(object sender, LayoutEventArgs e)
        {
            Assert.Same(parent, sender);
            Assert.Same(control, e.AffectedControl);
            Assert.Equal("Bounds", e.AffectedProperty);
            Assert.Equal(resizeCallCount - 1, parentLayoutCallCount);
            Assert.Equal(layoutCallCount - 1, parentLayoutCallCount);
            Assert.Equal(sizeChangedCallCount - 1, parentLayoutCallCount);
            Assert.Equal(clientSizeChangedCallCount - 1, parentLayoutCallCount);
            parentLayoutCallCount++;
        }

        parent.Layout += parentHandler;

        try
        {
            control.SetBoundsCore(x, y, width, height, specified);
            Assert.Equal(new Size(width, height), control.ClientSize);
            Assert.Equal(new Rectangle(0, 0, width, height), control.ClientRectangle);
            Assert.Equal(new Rectangle(0, 0, width, height), control.DisplayRectangle);
            Assert.Equal(new Size(width, height), control.Size);
            Assert.Equal(x, control.Left);
            Assert.Equal(x + width, control.Right);
            Assert.Equal(y, control.Top);
            Assert.Equal(y + height, control.Bottom);
            Assert.Equal(width, control.Width);
            Assert.Equal(height, control.Height);
            Assert.Equal(new Rectangle(x, y, width, height), control.Bounds);
            Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
            Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
            Assert.Equal(1, layoutCallCount);
            Assert.Equal(1, resizeCallCount);
            Assert.Equal(1, sizeChangedCallCount);
            Assert.Equal(1, clientSizeChangedCallCount);
            Assert.Equal(1, parentLayoutCallCount);
            Assert.False(control.IsHandleCreated);

            // Call again.
            control.SetBoundsCore(x, y, width, height, specified);
            Assert.Equal(new Size(width, height), control.ClientSize);
            Assert.Equal(new Rectangle(0, 0, width, height), control.ClientRectangle);
            Assert.Equal(new Rectangle(0, 0, width, height), control.DisplayRectangle);
            Assert.Equal(new Size(width, height), control.Size);
            Assert.Equal(x, control.Left);
            Assert.Equal(x + width, control.Right);
            Assert.Equal(y, control.Top);
            Assert.Equal(y + height, control.Bottom);
            Assert.Equal(width, control.Width);
            Assert.Equal(height, control.Height);
            Assert.Equal(new Rectangle(x, y, width, height), control.Bounds);
            Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
            Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
            Assert.Equal(1, layoutCallCount);
            Assert.Equal(1, resizeCallCount);
            Assert.Equal(1, sizeChangedCallCount);
            Assert.Equal(1, clientSizeChangedCallCount);
            Assert.Equal(1, parentLayoutCallCount);
            Assert.False(control.IsHandleCreated);
        }
        finally
        {
            parent.Layout -= parentHandler;
        }
    }

    public static IEnumerable<object[]> SetBoundsCore_WithHandle_TestData()
    {
        foreach (BoundsSpecified specified in Enum.GetValues(typeof(BoundsSpecified)))
        {
            yield return new object[] { true, 0, 0, 0, 0, specified, 0, 0, 0, 1 };
            yield return new object[] { true, -1, -2, -3, -4, specified, 0, 0, 1, 1 };
            yield return new object[] { true, 1, 0, 0, 0, specified, 0, 0, 1, 1 };
            yield return new object[] { true, 0, 2, 0, 0, specified, 0, 0, 1, 1 };
            yield return new object[] { true, 1, 2, 0, 0, specified, 0, 0, 1, 1 };
            yield return new object[] { true, 0, 0, 1, 0, specified, 1, 0, 0, 1 };
            yield return new object[] { true, 0, 0, 0, 2, specified, 0, 2, 0, 1 };
            yield return new object[] { true, 0, 0, 1, 2, specified, 1, 2, 0, 1 };
            yield return new object[] { true, 1, 2, 30, 40, specified, 30, 40, 1, 1 };

            yield return new object[] { false, 0, 0, 0, 0, specified, 0, 0, 0, 0 };
            yield return new object[] { false, -1, -2, -3, -4, specified, 0, 0, 1, 0 };
            yield return new object[] { false, 1, 0, 0, 0, specified, 0, 0, 1, 0 };
            yield return new object[] { false, 0, 2, 0, 0, specified, 0, 0, 1, 0 };
            yield return new object[] { false, 1, 2, 0, 0, specified, 0, 0, 1, 0 };
            yield return new object[] { false, 0, 0, 1, 0, specified, 1, 0, 0, 0 };
            yield return new object[] { false, 0, 0, 0, 2, specified, 0, 2, 0, 0 };
            yield return new object[] { false, 0, 0, 1, 2, specified, 1, 2, 0, 0 };
            yield return new object[] { false, 1, 2, 30, 40, specified, 30, 40, 1, 0 };
        }
    }

    [WinFormsTheory]
    [MemberData(nameof(SetBoundsCore_WithHandle_TestData))]
    public void TabPage_SetBoundsCore_InvokeWithHandle_Success(bool resizeRedraw, int x, int y, int width, int height, BoundsSpecified specified, int expectedWidth, int expectedHeight, int expectedLocationChangedCallCount, int expectedInvalidatedCallCount)
    {
        using SubTabPage control = new();
        control.SetStyle(ControlStyles.ResizeRedraw, resizeRedraw);
        Assert.NotEqual(IntPtr.Zero, control.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;

        int moveCallCount = 0;
        int locationChangedCallCount = 0;
        int layoutCallCount = 0;
        int resizeCallCount = 0;
        int sizeChangedCallCount = 0;
        int clientSizeChangedCallCount = 0;
        control.Move += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(locationChangedCallCount, moveCallCount);
            Assert.Equal(layoutCallCount, moveCallCount);
            Assert.Equal(resizeCallCount, moveCallCount);
            Assert.Equal(sizeChangedCallCount, moveCallCount);
            Assert.Equal(clientSizeChangedCallCount, moveCallCount);
            moveCallCount++;
        };
        control.LocationChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(moveCallCount - 1, locationChangedCallCount);
            Assert.Equal(layoutCallCount, locationChangedCallCount);
            Assert.Equal(resizeCallCount, locationChangedCallCount);
            Assert.Equal(sizeChangedCallCount, locationChangedCallCount);
            Assert.Equal(clientSizeChangedCallCount, locationChangedCallCount);
            locationChangedCallCount++;
        };
        control.Layout += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(control, e.AffectedControl);
            Assert.Equal("Bounds", e.AffectedProperty);
            Assert.Equal(resizeCallCount, layoutCallCount);
            Assert.Equal(sizeChangedCallCount, layoutCallCount);
            Assert.Equal(clientSizeChangedCallCount, layoutCallCount);
            layoutCallCount++;
        };
        control.Resize += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(layoutCallCount - 1, resizeCallCount);
            Assert.Equal(sizeChangedCallCount, resizeCallCount);
            Assert.Equal(clientSizeChangedCallCount, resizeCallCount);
            resizeCallCount++;
        };
        control.SizeChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(resizeCallCount - 1, sizeChangedCallCount);
            Assert.Equal(layoutCallCount - 1, sizeChangedCallCount);
            Assert.Equal(clientSizeChangedCallCount, sizeChangedCallCount);
            sizeChangedCallCount++;
        };
        control.ClientSizeChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(resizeCallCount - 1, clientSizeChangedCallCount);
            Assert.Equal(layoutCallCount - 1, clientSizeChangedCallCount);
            Assert.Equal(sizeChangedCallCount - 1, clientSizeChangedCallCount);
            clientSizeChangedCallCount++;
        };

        control.SetBoundsCore(x, y, width, height, specified);
        Assert.Equal(new Size(expectedWidth, expectedHeight), control.ClientSize);
        Assert.Equal(new Rectangle(0, 0, expectedWidth, expectedHeight), control.ClientRectangle);
        Assert.Equal(new Rectangle(0, 0, expectedWidth, expectedHeight), control.DisplayRectangle);
        Assert.Equal(new Size(expectedWidth, expectedHeight), control.Size);
        Assert.Equal(x, control.Left);
        Assert.Equal(x + expectedWidth, control.Right);
        Assert.Equal(y, control.Top);
        Assert.Equal(y + expectedHeight, control.Bottom);
        Assert.Equal(expectedWidth, control.Width);
        Assert.Equal(expectedHeight, control.Height);
        Assert.Equal(new Rectangle(x, y, expectedWidth, expectedHeight), control.Bounds);
        Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
        Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
        Assert.Equal(1, layoutCallCount);
        Assert.Equal(1, resizeCallCount);
        Assert.Equal(1, sizeChangedCallCount);
        Assert.Equal(1, clientSizeChangedCallCount);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);

        // Call again.
        control.SetBoundsCore(x, y, width, height, specified);
        Assert.Equal(new Size(expectedWidth, expectedHeight), control.ClientSize);
        Assert.Equal(new Rectangle(0, 0, expectedWidth, expectedHeight), control.ClientRectangle);
        Assert.Equal(new Rectangle(0, 0, expectedWidth, expectedHeight), control.DisplayRectangle);
        Assert.Equal(new Size(expectedWidth, expectedHeight), control.Size);
        Assert.Equal(x, control.Left);
        Assert.Equal(x + expectedWidth, control.Right);
        Assert.Equal(y, control.Top);
        Assert.Equal(y + expectedHeight, control.Bottom);
        Assert.Equal(expectedWidth, control.Width);
        Assert.Equal(expectedHeight, control.Height);
        Assert.Equal(new Rectangle(x, y, expectedWidth, expectedHeight), control.Bounds);
        Assert.Equal(expectedLocationChangedCallCount, moveCallCount);
        Assert.Equal(expectedLocationChangedCallCount, locationChangedCallCount);
        Assert.Equal(1, layoutCallCount);
        Assert.Equal(1, resizeCallCount);
        Assert.Equal(1, sizeChangedCallCount);
        Assert.Equal(1, clientSizeChangedCallCount);
        Assert.True(control.IsHandleCreated);
        Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);
        Assert.Equal(0, styleChangedCallCount);
        Assert.Equal(0, createdCallCount);
    }

    public static IEnumerable<object[]> SetBoundsCore_WithParentWithHandle_TestData()
    {
        foreach (BoundsSpecified specified in Enum.GetValues(typeof(BoundsSpecified)))
        {
            foreach (bool resizeRedraw in new bool[] { true, false })
            {
                yield return new object[] { resizeRedraw, 0, 0, 0, 0, specified };
                yield return new object[] { resizeRedraw, -1, -2, -3, -4, specified };
                yield return new object[] { resizeRedraw, 1, 0, 0, 0, specified };
                yield return new object[] { resizeRedraw, 0, 2, 0, 0, specified };
                yield return new object[] { resizeRedraw, 1, 2, 0, 0, specified };
                yield return new object[] { resizeRedraw, 0, 0, 1, 0, specified };
                yield return new object[] { resizeRedraw, 0, 0, 0, 2, specified };
                yield return new object[] { resizeRedraw, 0, 0, 1, 2, specified };
                yield return new object[] { resizeRedraw, 1, 2, 30, 40, specified };
            }
        }
    }

    [WinFormsTheory]
    [MemberData(nameof(SetBoundsCore_WithParentWithHandle_TestData))]
    public void TabPage_SetBoundsCore_InvokeWithParentWithHandle_Success(bool resizeRedraw, int x, int y, int width, int height, BoundsSpecified specified)
    {
        using TabControl parent = new();
        using SubTabPage control = new()
        {
            Parent = parent
        };
        control.SetStyle(ControlStyles.ResizeRedraw, resizeRedraw);
        Assert.NotEqual(IntPtr.Zero, parent.Handle);
        int invalidatedCallCount = 0;
        control.Invalidated += (sender, e) => invalidatedCallCount++;
        int styleChangedCallCount = 0;
        control.StyleChanged += (sender, e) => styleChangedCallCount++;
        int createdCallCount = 0;
        control.HandleCreated += (sender, e) => createdCallCount++;
        int parentInvalidatedCallCount = 0;
        parent.Invalidated += (sender, e) => parentInvalidatedCallCount++;
        int parentStyleChangedCallCount = 0;
        parent.StyleChanged += (sender, e) => parentStyleChangedCallCount++;
        int parentCreatedCallCount = 0;
        parent.HandleCreated += (sender, e) => parentCreatedCallCount++;
        Rectangle expected = parent.DisplayRectangle;

        int moveCallCount = 0;
        int locationChangedCallCount = 0;
        int layoutCallCount = 0;
        int resizeCallCount = 0;
        int sizeChangedCallCount = 0;
        int clientSizeChangedCallCount = 0;
        int parentLayoutCallCount = 0;
        control.Move += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(locationChangedCallCount, moveCallCount);
            Assert.Equal(layoutCallCount, moveCallCount);
            Assert.Equal(resizeCallCount, moveCallCount);
            Assert.Equal(sizeChangedCallCount, moveCallCount);
            Assert.Equal(clientSizeChangedCallCount, moveCallCount);
            moveCallCount++;
        };
        control.LocationChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(moveCallCount - 1, locationChangedCallCount);
            Assert.Equal(layoutCallCount, locationChangedCallCount);
            Assert.Equal(resizeCallCount, locationChangedCallCount);
            Assert.Equal(sizeChangedCallCount, locationChangedCallCount);
            Assert.Equal(clientSizeChangedCallCount, locationChangedCallCount);
            locationChangedCallCount++;
        };
        control.Layout += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(control, e.AffectedControl);
            Assert.Equal("Bounds", e.AffectedProperty);
            Assert.Equal(resizeCallCount, layoutCallCount);
            Assert.Equal(sizeChangedCallCount, layoutCallCount);
            Assert.Equal(clientSizeChangedCallCount, layoutCallCount);
            Assert.Equal(parentLayoutCallCount, layoutCallCount);
            layoutCallCount++;
        };
        control.Resize += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(layoutCallCount - 1, resizeCallCount);
            Assert.Equal(sizeChangedCallCount, resizeCallCount);
            Assert.Equal(clientSizeChangedCallCount, resizeCallCount);
            Assert.Equal(parentLayoutCallCount, resizeCallCount);
            resizeCallCount++;
        };
        control.SizeChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(resizeCallCount - 1, sizeChangedCallCount);
            Assert.Equal(layoutCallCount - 1, sizeChangedCallCount);
            Assert.Equal(clientSizeChangedCallCount, sizeChangedCallCount);
            Assert.Equal(parentLayoutCallCount, sizeChangedCallCount);
            sizeChangedCallCount++;
        };
        control.ClientSizeChanged += (sender, e) =>
        {
            Assert.Same(control, sender);
            Assert.Same(EventArgs.Empty, e);
            Assert.Equal(resizeCallCount - 1, clientSizeChangedCallCount);
            Assert.Equal(layoutCallCount - 1, clientSizeChangedCallCount);
            Assert.Equal(sizeChangedCallCount - 1, clientSizeChangedCallCount);
            Assert.Equal(parentLayoutCallCount, clientSizeChangedCallCount);
            clientSizeChangedCallCount++;
        };
        void parentHandler(object sender, LayoutEventArgs e)
        {
            Assert.Same(parent, sender);
            Assert.Same(control, e.AffectedControl);
            Assert.Equal("Bounds", e.AffectedProperty);
            Assert.Equal(resizeCallCount - 1, parentLayoutCallCount);
            Assert.Equal(layoutCallCount - 1, parentLayoutCallCount);
            Assert.Equal(sizeChangedCallCount - 1, parentLayoutCallCount);
            Assert.Equal(clientSizeChangedCallCount - 1, parentLayoutCallCount);
            parentLayoutCallCount++;
        }

        parent.Layout += parentHandler;

        try
        {
            control.SetBoundsCore(x, y, width, height, specified);
            Assert.Equal(expected.Size, control.ClientSize);
            Assert.Equal(new Rectangle(0, 0, expected.Width, expected.Height), control.ClientRectangle);
            Assert.Equal(new Rectangle(0, 0, expected.Width, expected.Height), control.DisplayRectangle);
            Assert.Equal(expected.Size, control.Size);
            Assert.Equal(expected.X, control.Left);
            Assert.Equal(expected.X + expected.Width, control.Right);
            Assert.Equal(expected.Location, control.Location);
            Assert.Equal(expected.Y, control.Top);
            Assert.Equal(expected.Y + expected.Height, control.Bottom);
            Assert.Equal(expected.Width, control.Width);
            Assert.Equal(expected.Height, control.Height);
            Assert.Equal(expected, control.Bounds);
            Assert.Equal(0, moveCallCount);
            Assert.Equal(0, locationChangedCallCount);
            Assert.Equal(0, layoutCallCount);
            Assert.Equal(0, parentLayoutCallCount);
            Assert.Equal(0, resizeCallCount);
            Assert.Equal(0, sizeChangedCallCount);
            Assert.Equal(0, clientSizeChangedCallCount);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
            Assert.True(parent.IsHandleCreated);
            Assert.Equal(0, parentInvalidatedCallCount);
            Assert.Equal(0, parentStyleChangedCallCount);
            Assert.Equal(0, parentCreatedCallCount);

            // Call again.
            control.SetBoundsCore(x, y, width, height, specified);
            Assert.Equal(expected.Size, control.ClientSize);
            Assert.Equal(new Rectangle(0, 0, expected.Width, expected.Height), control.ClientRectangle);
            Assert.Equal(new Rectangle(0, 0, expected.Width, expected.Height), control.DisplayRectangle);
            Assert.Equal(expected.Size, control.Size);
            Assert.Equal(expected.X, control.Left);
            Assert.Equal(expected.X + expected.Width, control.Right);
            Assert.Equal(expected.Location, control.Location);
            Assert.Equal(expected.Y, control.Top);
            Assert.Equal(expected.Y + expected.Height, control.Bottom);
            Assert.Equal(expected.Width, control.Width);
            Assert.Equal(expected.Height, control.Height);
            Assert.Equal(expected, control.Bounds);
            Assert.Equal(0, moveCallCount);
            Assert.Equal(0, locationChangedCallCount);
            Assert.Equal(0, layoutCallCount);
            Assert.Equal(0, parentLayoutCallCount);
            Assert.Equal(0, resizeCallCount);
            Assert.Equal(0, sizeChangedCallCount);
            Assert.Equal(0, clientSizeChangedCallCount);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
            Assert.True(parent.IsHandleCreated);
            Assert.Equal(0, parentInvalidatedCallCount);
            Assert.Equal(0, parentStyleChangedCallCount);
            Assert.Equal(0, parentCreatedCallCount);
        }
        finally
        {
            parent.Layout -= parentHandler;
        }
    }

    [WinFormsFact]
    public void TabPage_ToString_Invoke_ReturnsExpected()
    {
        using TabPage control = new();
        Assert.Equal("TabPage: {}", control.ToString());
    }

    [WinFormsFact]
    public void TabPage_ToString_InvokeWithText_ReturnsExpected()
    {
        using TabPage control = new("text");
        Assert.Equal("TabPage: {text}", control.ToString());
    }

    [WinFormsFact]
    public void TabPage_ToString_InvokeWithNullText_ReturnsExpected()
    {
        using NullTextTabPage control = new();
        Assert.Equal("TabPage: {}", control.ToString());
    }

    [WinFormsFact]
    public void TabPage_GetCaptionForTool_ReturnsToolTipText_IfToolTipTextIsSet()
    {
        using TabPage control = new();
        string text = "Some test text";
        control.ToolTipText = text;
        using ToolTip toolTip = new();

        string actual = ((IKeyboardToolTip)control).GetCaptionForTool(toolTip);

        Assert.Equal(text, actual);
    }

    [WinFormsFact]
    public void TabPage_GetCaptionForTool_ReturnsExternalToolTipText_IfInternalsAreNotSet()
    {
        using TabPage control = new();
        using ToolTip toolTip = new();
        control.CreateControl();

        Assert.NotEqual(IntPtr.Zero, toolTip.Handle); // A workaround to create the tooltip native window Handle

        string text = "Some test text";
        toolTip.SetToolTip(control, text);

        string actual = ((IKeyboardToolTip)control).GetCaptionForTool(toolTip);

        Assert.Equal(text, actual);
    }

    [WinFormsFact]
    public void TabPage_GetCaptionForTool_ReturnsNull_IfNoToolTipIsSet()
    {
        using TabPage control = new();
        using ToolTip toolTip = new();

        string actual = ((IKeyboardToolTip)control).GetCaptionForTool(toolTip);

        Assert.Null(actual);
    }

    [WinFormsFact]
    public void TabPage_GetNeighboringToolsRectangles_ReturnsEmptyCollection_IfPageDoesntHaveTabControl()
    {
        using TabPage control = new();

        IList<Rectangle> actual = ((IKeyboardToolTip)control).GetNeighboringToolsRectangles();

        Assert.Empty(actual);
    }

    [WinFormsTheory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    public void TabPage_GetNeighboringToolsRectangles_ReturnsCorrect(int index)
    {
        using TabControl tabControl = new();
        const int pagesCount = 5;

        for (int i = 0; i < pagesCount; i++)
        {
            tabControl.TabPages.Add(new TabPage());
        }

        TabPage testedTab = tabControl.TabPages[index];
        IList<Rectangle> neighborsRectangles = ((IKeyboardToolTip)testedTab).GetNeighboringToolsRectangles();

        Assert.NotEmpty(neighborsRectangles);

        if (index > 0) // has the left neighbor
        {
            Assert.True(neighborsRectangles.Contains(GetTabRect(index - 1))); // check the left neighbor

            for (int i = 0; i < index - 1; i++)
            {
                Assert.False(neighborsRectangles.Contains(GetTabRect(i))); // check the rest lefts
            }
        }

        if (index < pagesCount - 1) // has the right neighbor
        {
            Assert.True(neighborsRectangles.Contains(GetTabRect(index + 1))); // check the right neighbor

            for (int i = index + 2; i < pagesCount; i++)
            {
                Assert.False(neighborsRectangles.Contains(GetTabRect(i))); // check the rest rights
            }
        }

        Rectangle GetTabRect(int index)
            => tabControl.RectangleToScreen(tabControl.GetTabRect(index));
    }

    [WinFormsFact]
    public void TabPage_InternalToolTip_IsSet_IfNoExternalIsSet()
    {
        using TabPage control = new();
        string text = "Some test text";
        control.ToolTipText = text;

        ToolTip internalToolTip = control.TestAccessor().Dynamic._internalToolTip;
        string actual = internalToolTip.GetCaptionForTool(control);

        Assert.Equal(text, actual);
    }

    [WinFormsFact]
    public void TabPage_InternalToolTip_IsNotSet_IfExternalIsSet()
    {
        using TabPage control = new();
        using ToolTip toolTip = new();
        string text = "Some test text";
        control.ToolTipText = text;
        control.CreateControl();

        Assert.NotEqual(IntPtr.Zero, toolTip.Handle); // A workaround to create the tooltip native window Handle

        toolTip.SetToolTip(control, text);
        ToolTip internalToolTip = control.TestAccessor().Dynamic._internalToolTip;
        string actual = internalToolTip.GetCaptionForTool(control);

        Assert.Null(actual);
    }

    [WinFormsFact]
    public void TabPage_GetToolNativeScreenRectangle_ReturnsExpected()
    {
        using TabControl tabControl = new();
        using TabPage page = new();
        tabControl.TabPages.Add(page);

        Rectangle expected = tabControl.RectangleToScreen(tabControl.GetTabRect(0));
        Rectangle actual = page.GetToolNativeScreenRectangle();

        Assert.Equal(expected, actual);
    }

    [WinFormsFact]
    public void TabPage_GetToolNativeScreenRectangle_ReturnsEmpty_WithoutParent()
    {
        using TabPage control = new();

        Rectangle actual = control.GetToolNativeScreenRectangle();

        Assert.Equal(Rectangle.Empty, actual);
    }

    [WinFormsTheory]
    [InlineData(true, null)]
    [InlineData(false, "Some test text")]
    public void TabPage_SetToolTip_ManagesAssociatedToolTips_ForOneToolTipInstance(bool createToolTip, string expectedText)
    {
        using TabPage control = new();
        string text = "Some test text";
        control.ToolTipText = text;

        dynamic tabPageDynamic = control.TestAccessor().Dynamic;
        ToolTip internalToolTip = tabPageDynamic._internalToolTip;
        ToolTip externalToolTip = tabPageDynamic._externalToolTip;
        List<ToolTip> associatedToolTips = tabPageDynamic._associatedToolTips;
        string actualText = internalToolTip.GetCaptionForTool(control);

        Assert.Equal(text, actualText);
        Assert.Null(externalToolTip);
        Assert.Null(associatedToolTips);

        using ToolTip toolTip = createToolTip
            ? new ToolTip() // TabPage's SetToolTip will clear the internal toolTip because external one is set
            : null;  // TabPage's SetToolTip won't change states of fields and won't throw any exceptions

        control.SetToolTip(toolTip);

        externalToolTip = tabPageDynamic._externalToolTip;
        associatedToolTips = tabPageDynamic._associatedToolTips;
        actualText = internalToolTip.GetCaptionForTool(control);

        Assert.Equal(expectedText, actualText);
        Assert.Equal(toolTip, externalToolTip);
        Assert.Null(associatedToolTips);
    }

    [WinFormsFact]
    public void TabPage_SetToolTip_ManagesInternalAndAssociatedToolTips_ForTwoToolTipInstances()
    {
        using TabPage control = new();
        string text = "Some test text";
        control.ToolTipText = text;

        dynamic tabPageDynamic = control.TestAccessor().Dynamic;
        ToolTip internalToolTip = tabPageDynamic._internalToolTip;
        ToolTip externalToolTip = tabPageDynamic._externalToolTip;
        List<ToolTip> associatedToolTips = tabPageDynamic._associatedToolTips;
        string actualText = internalToolTip.GetCaptionForTool(control);

        Assert.Equal(text, actualText);
        Assert.Null(externalToolTip);
        Assert.Null(associatedToolTips);

        using ToolTip toolTip1 = new();
        using ToolTip toolTip2 = new();

        control.SetToolTip(toolTip1);
        control.SetToolTip(toolTip2);

        actualText = internalToolTip.GetCaptionForTool(control);
        externalToolTip = tabPageDynamic._externalToolTip;
        associatedToolTips = tabPageDynamic._associatedToolTips;

        Assert.Null(actualText);
        Assert.Equal(toolTip1, externalToolTip);
        Assert.Equal(2, associatedToolTips.Count);
        Assert.Equal(toolTip1, associatedToolTips[0]);
        Assert.Equal(toolTip2, associatedToolTips[1]);
    }

    [WinFormsTheory]
    [InlineData(true, true)]
    [InlineData(false, false)]
    public void TabPage_RemoveToolTip_ManagesAssociatedToolTips_ForOneToolTipInstance(bool createToolTip, bool setToolTip)
    {
        using TabPage control = new();
        string text = "Some test text";
        control.ToolTipText = text;

        dynamic tabPageDynamic = control.TestAccessor().Dynamic;
        ToolTip internalToolTip = tabPageDynamic._internalToolTip;
        ToolTip externalToolTip = tabPageDynamic._externalToolTip;

        using ToolTip toolTip = createToolTip
            ? new ToolTip() // TabPage's RemoveToolTip will clear the internal toolTip because external one is set
            : null;  // TabPage's RemoveToolTip won't change states of fields and won't throw any exceptions

        if (createToolTip && setToolTip)
        {
            // A simple workaround in the test to set expected states for fields
            control.SetToolTip(toolTip);
        }

        control.RemoveToolTip(toolTip);

        List<ToolTip> associatedToolTips = tabPageDynamic._associatedToolTips;
        string actualText = internalToolTip.GetCaptionForTool(control);

        Assert.Equal(text, actualText);
        Assert.Null(externalToolTip);
        Assert.Null(associatedToolTips);
    }

    [WinFormsFact]
    public void TabPage_RemoveToolTip_ManagesAssociatedToolTips_ForTwoToolTipInstances()
    {
        using TabPage control = new();
        string text = "Some test text";
        control.ToolTipText = text;

        dynamic tabPageDynamic = control.TestAccessor().Dynamic;
        ToolTip internalToolTip = tabPageDynamic._internalToolTip;

        using ToolTip toolTip1 = new();
        using ToolTip toolTip2 = new();

        // A simple workaround in the test to set expected states for fields
        control.SetToolTip(toolTip1);
        control.SetToolTip(toolTip2);

        control.RemoveToolTip(toolTip1);

        List<ToolTip> associatedToolTips = tabPageDynamic._associatedToolTips;
        ToolTip externalToolTip = tabPageDynamic._externalToolTip;

        Assert.Equal(toolTip2, externalToolTip);
        Assert.Null(associatedToolTips);
    }

    [WinFormsFact]
    public void TabPage_RemoveToolTip_ManagesAssociatedToolTips_ForThreeToolTipInstances()
    {
        using TabPage control = new();
        string text = "Some test text";
        control.ToolTipText = text;

        dynamic tabPageDynamic = control.TestAccessor().Dynamic;
        ToolTip internalToolTip = tabPageDynamic._internalToolTip;
        ToolTip externalToolTip = tabPageDynamic._externalToolTip;

        using ToolTip toolTip1 = new();
        using ToolTip toolTip2 = new();
        using ToolTip toolTip3 = new();

        // A simple workaround in the test to set expected states for fields
        control.SetToolTip(toolTip1);
        control.SetToolTip(toolTip2);
        control.SetToolTip(toolTip3);

        control.RemoveToolTip(toolTip1);

        List<ToolTip> associatedToolTips = tabPageDynamic._associatedToolTips;

        Assert.Equal(2, associatedToolTips.Count);
        Assert.Equal(toolTip2, associatedToolTips[0]);
        Assert.Equal(toolTip3, associatedToolTips[1]);
    }

    private class NullTextTabPage : TabPage
    {
        public override string Text
        {
            get => null;
            set { }
        }
    }

    private class SubTabPage : TabPage
    {
        public new const int ScrollStateAutoScrolling = ScrollableControl.ScrollStateAutoScrolling;

        public new const int ScrollStateHScrollVisible = ScrollableControl.ScrollStateHScrollVisible;

        public new const int ScrollStateVScrollVisible = ScrollableControl.ScrollStateVScrollVisible;

        public new const int ScrollStateUserHasScrolled = ScrollableControl.ScrollStateUserHasScrolled;

        public new const int ScrollStateFullDrag = ScrollableControl.ScrollStateFullDrag;

        public SubTabPage() : base()
        {
        }

        public SubTabPage(string text) : base(text)
        {
        }

        public new bool CanEnableIme => base.CanEnableIme;

        public new bool CanRaiseEvents => base.CanRaiseEvents;

        public new CreateParams CreateParams => base.CreateParams;

        public new Cursor DefaultCursor => base.DefaultCursor;

        public new ImeMode DefaultImeMode => base.DefaultImeMode;

        public new Padding DefaultMargin => base.DefaultMargin;

        public new Size DefaultMaximumSize => base.DefaultMaximumSize;

        public new Size DefaultMinimumSize => base.DefaultMinimumSize;

        public new Padding DefaultPadding => base.DefaultPadding;

        public new Size DefaultSize => base.DefaultSize;

        public new bool DesignMode => base.DesignMode;

        public new bool DoubleBuffered
        {
            get => base.DoubleBuffered;
            set => base.DoubleBuffered = value;
        }

        public new EventHandlerList Events => base.Events;

        public new int FontHeight
        {
            get => base.FontHeight;
            set => base.FontHeight = value;
        }

        public new ImeMode ImeModeBase
        {
            get => base.ImeModeBase;
            set => base.ImeModeBase = value;
        }

        public new bool HScroll
        {
            get => base.HScroll;
            set => base.HScroll = value;
        }

        public new bool ResizeRedraw
        {
            get => base.ResizeRedraw;
            set => base.ResizeRedraw = value;
        }

        public new bool ShowFocusCues => base.ShowFocusCues;

        public new bool ShowKeyboardCues => base.ShowKeyboardCues;

        public new bool VScroll
        {
            get => base.VScroll;
            set => base.VScroll = value;
        }

        public new ControlCollection CreateControlsInstance() => base.CreateControlsInstance();

        public new AutoSizeMode GetAutoSizeMode() => base.GetAutoSizeMode();

        public new bool GetScrollState(int bit) => base.GetScrollState(bit);

        public new bool GetStyle(ControlStyles flag) => base.GetStyle(flag);

        public new bool GetTopLevel() => base.GetTopLevel();

        public new void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified) => base.SetBoundsCore(x, y, width, height, specified);

        public new void SetStyle(ControlStyles flag, bool value) => base.SetStyle(flag, value);

        public new void OnEnter(EventArgs e) => base.OnEnter(e);

        public new void OnLeave(EventArgs e) => base.OnLeave(e);

        public new void OnPaintBackground(PaintEventArgs e) => base.OnPaintBackground(e);
    }
}
