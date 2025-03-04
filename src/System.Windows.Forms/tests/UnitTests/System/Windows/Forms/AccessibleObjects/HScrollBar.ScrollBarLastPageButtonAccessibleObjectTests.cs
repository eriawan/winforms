﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

using System.Drawing;
using System.Windows.Forms.TestUtilities;
using Windows.Win32.UI.Accessibility;
using static System.Windows.Forms.ScrollBar;

namespace System.Windows.Forms.Tests.AccessibleObjects;

public class HScrollBar_ScrollBarLastPageButtonAccessibleObjectTests
{
    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_GetChild_ReturnNull(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Null(accessibleObject.GetChild(-1));
        Assert.Null(accessibleObject.GetChild(0));
        Assert.Null(accessibleObject.GetChild(1));
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_GetChildCount_ReturnMinusOne(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(-1, accessibleObject.GetChildCount());
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_Bounds_ReturnEmptyRectangle_IfHandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(Rectangle.Empty, accessibleObject.Bounds);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_DefaultAction_ReturnNotNull_HandleIsCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.NotEmpty(accessibleObject.DefaultAction);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_DefaultAction_ReturnNull_HandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Null(accessibleObject.DefaultAction);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_Description_ReturnNotNull_HandleIsCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.NotEmpty(accessibleObject.Description);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_Description_ReturnNull_HandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Null(accessibleObject.Description);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_Name_ReturnNotNull_HandleIsCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.NotEmpty(accessibleObject.Name);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_Name_ReturnNull_HandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Null(accessibleObject.Name);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_Role_ReturnNotNull(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);
        AccessibleRole expectedRole = createControl ? AccessibleRole.PushButton : AccessibleRole.None;

        Assert.Equal(expectedRole, accessibleObject.Role);
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_State_ReturnNone_IfHandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(AccessibleStates.None, accessibleObject.State);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_InvokePattern_Supported(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(createControl, accessibleObject.IsPatternSupported(UIA_PATTERN_ID.UIA_InvokePatternId));
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.HScrollBarAccessibleObject_LastPageButtonIsDisplayed_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_FragmentNavigate_ReturnExpected_LastPageButtonIsDisplayed(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        var scrollBarAccessibleObject = (ScrollBarAccessibleObject)scrollBar.AccessibilityObject;
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(scrollBarAccessibleObject, accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_Parent));
        Assert.Equal(scrollBarAccessibleObject.ThumbAccessibleObject, accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_PreviousSibling));
        Assert.Equal(scrollBarAccessibleObject.LastLineButtonAccessibleObject, accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_NextSibling));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_FirstChild));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_LastChild));
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.HScrollBarAccessibleObject_LastPageButtonIsHidden_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_FragmentNavigate_ReturnExpected_LastPageButtonIsHidden(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        var scrollBarAccessibleObject = (ScrollBarAccessibleObject)scrollBar.AccessibilityObject;
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(scrollBarAccessibleObject, accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_Parent));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_NextSibling));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_PreviousSibling));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_FirstChild));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_LastChild));
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_MinimumEqualsMaximum_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_FragmentNavigate_ReturnExpected_MinimumEqualsMaximum(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        var scrollBarAccessibleObject = (ScrollBarAccessibleObject)scrollBar.AccessibilityObject;
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(scrollBarAccessibleObject, accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_Parent));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_NextSibling));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_PreviousSibling));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_FirstChild));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_LastChild));
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_FragmentNavigate_ReturnNull_HandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_Parent));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_NextSibling));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_PreviousSibling));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_FirstChild));
        Assert.Null(accessibleObject.FragmentNavigate(NavigateDirection.NavigateDirection_LastChild));
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsFact]
    public void HScrollBarLastPageButtonAccessibleObject_Invoke_DecreaseValue()
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, RightToLeft.Yes, minimum: 0, maximum: 100, value: 50);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(50, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(48, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(46, scrollBar.Value);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsFact]
    public void HScrollBarLastPageButtonAccessibleObject_Invoke_IncreaseValue()
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, RightToLeft.No, minimum: 0, maximum: 100, value: 50);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(50, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(52, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(54, scrollBar.Value);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [InlineData(RightToLeft.No, 99, 100)]
    [InlineData(RightToLeft.No, 0, 0)]
    [InlineData(RightToLeft.Yes, 0, 100)]
    [InlineData(RightToLeft.Yes, 0, 0)]
    public void HScrollBarLastPageButtonAccessibleObject_Invoke_DoesNotWork_OutOfRange(RightToLeft rightToLeft, int value, int maximum)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum: 0, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(value, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(value, scrollBar.Value);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_Invoke_DoesNotWork_IfHandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(value, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(value, scrollBar.Value);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_MinimumEqualsMaximum_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_Invoke_DoesNotWork_MinimumEqualsMaximum(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(value, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(value, scrollBar.Value);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.HScrollBarAccessibleObject_LastPageButtonIsHidden_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_Invoke_DoesNotWork_LastPageButtonIsHidden(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.Equal(value, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(value, scrollBar.Value);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_GetPropertyValue_IsEnabledProperty_ReturnsTrue_OwnerEnabled(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        scrollBar.Enabled = true;
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.True((bool)accessibleObject.GetPropertyValue(UIA_PROPERTY_ID.UIA_IsEnabledPropertyId));
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_GetPropertyValue_IsEnabledProperty_ReturnsFalse_OwnerDisabled(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        scrollBar.Enabled = false;
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.False((bool)accessibleObject.GetPropertyValue(UIA_PROPERTY_ID.UIA_IsEnabledPropertyId));
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.HScrollBarAccessibleObject_LastPageButtonIsDisplayed_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_IsDisplayed_ReturnsTrue_OwnerVisible(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        scrollBar.Visible = true;
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.True(accessibleObject.IsDisplayed);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.HScrollBarAccessibleObject_LastPageButtonIsDisplayed_TestData))]
    public void HScrollBarLastPageButtonAccessibleObject_IsDisplayed_ReturnsFalse_OwnerInvisible(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        scrollBar.Visible = false;
        ScrollBarLastPageButtonAccessibleObject accessibleObject = GetLastPageButton(scrollBar);

        Assert.False(accessibleObject.IsDisplayed);
        Assert.False(scrollBar.IsHandleCreated);
    }

    private HScrollBar GetHScrollBar(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        HScrollBar hScrollBar = new()
        {
            RightToLeft = rightToLeft,
            Value = value,
            Minimum = minimum,
            Maximum = maximum,
            Size = new Size(200, 50),
            SmallChange = 1,
            LargeChange = 2
        };

        if (createControl)
        {
            hScrollBar.CreateControl();
        }

        return hScrollBar;
    }

    private ScrollBarLastPageButtonAccessibleObject GetLastPageButton(ScrollBar scrollBar)
    {
        var accessibleObject = (ScrollBarAccessibleObject)scrollBar.AccessibilityObject;
        return accessibleObject.LastPageButtonAccessibleObject;
    }
}
