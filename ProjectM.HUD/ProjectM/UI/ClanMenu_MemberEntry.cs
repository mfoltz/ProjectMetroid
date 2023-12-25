// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ClanMenu_MemberEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ClanMenu_MemberEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_You;
    private static readonly System.IntPtr NativeFieldInfoPtr_Location;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoleIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Motion;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameColor_You;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameColor_NotYou;
    private static readonly System.IntPtr NativeFieldInfoPtr_Alpha_Online;
    private static readonly System.IntPtr NativeFieldInfoPtr_Alpha_Offline;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoleIcon_Leader;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoleIcon_Officer;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoleIcon_Member;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Offline;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanRole;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ClanMenu_MemberEntry_byref_Data_GridSelectionGroup_2_ClanMenu_MemberEntry_Data_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1232506, RefRangeEnd = 1232507, XrefRangeStart = 1232484, XrefRangeEnd = 1232506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(
      ClanMenu_MemberEntry entry,
      [In] ref ClanMenu_MemberEntry.Data data,
      GridSelectionGroup<ClanMenu_MemberEntry, ClanMenu_MemberEntry.Data> parent,
      bool showPanel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &showPanel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanMenu_MemberEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ClanMenu_MemberEntry_byref_Data_GridSelectionGroup_2_ClanMenu_MemberEntry_Data_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClanMenu_MemberEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanMenu_MemberEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClanMenu_MemberEntry()
    {
      Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ClanMenu_MemberEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr);
      ClanMenu_MemberEntry.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (CanvasGroup));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (Name));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_You = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (You));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (Location));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (RoleIcon));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_Motion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (Motion));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_NameColor_You = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (NameColor_You));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_NameColor_NotYou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (NameColor_NotYou));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_Alpha_Online = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (Alpha_Online));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_Alpha_Offline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (Alpha_Offline));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon_Leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (RoleIcon_Leader));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon_Officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (RoleIcon_Officer));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon_Member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (RoleIcon_Member));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_LKey_Offline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (LKey_Offline));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_ClanRole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (ClanRole));
      ClanMenu_MemberEntry.NativeFieldInfoPtr_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (UserIndex));
      ClanMenu_MemberEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ClanMenu_MemberEntry_byref_Data_GridSelectionGroup_2_ClanMenu_MemberEntry_Data_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, 100665472);
      ClanMenu_MemberEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, 100665473);
    }

    public ClanMenu_MemberEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CanvasGroup CanvasGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_CanvasGroup));
        return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_Name));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText You
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_You));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_You), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Location
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_Location));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image RoleIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut Motion
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_Motion));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_Motion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color NameColor_You
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_NameColor_You));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_NameColor_You)) = value;
      }
    }

    public unsafe Color NameColor_NotYou
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_NameColor_NotYou));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_NameColor_NotYou)) = value;
      }
    }

    public unsafe float Alpha_Online
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_Alpha_Online));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_Alpha_Online)) = value;
      }
    }

    public unsafe float Alpha_Offline
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_Alpha_Offline));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_Alpha_Offline)) = value;
      }
    }

    public unsafe Sprite RoleIcon_Leader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon_Leader));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon_Leader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite RoleIcon_Officer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon_Officer));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon_Officer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite RoleIcon_Member
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon_Member));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_RoleIcon_Member), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Offline
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_LKey_Offline));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_LKey_Offline)) = value;
      }
    }

    public unsafe ClanRoleEnum ClanRole
    {
      get
      {
        return *(ClanRoleEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_ClanRole));
      }
      [param: In] set
      {
        *(ClanRoleEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_ClanRole)) = value;
      }
    }

    public unsafe int UserIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_UserIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.NativeFieldInfoPtr_UserIndex)) = value;
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_UserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClanRole;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsLocalPlayer;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsOnline;

      static Data()
      {
        Il2CppClassPointerStore<ClanMenu_MemberEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanMenu_MemberEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanMenu_MemberEntry.Data>.NativeClassPtr);
        ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry.Data>.NativeClassPtr, nameof (Name));
        ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry.Data>.NativeClassPtr, nameof (UserIndex));
        ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_ClanRole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry.Data>.NativeClassPtr, nameof (ClanRole));
        ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_IsLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry.Data>.NativeClassPtr, nameof (IsLocalPlayer));
        ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_IsOnline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_MemberEntry.Data>.NativeClassPtr, nameof (IsOnline));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClanMenu_MemberEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanMenu_MemberEntry.Data>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int UserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_UserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_UserIndex)) = value;
        }
      }

      public unsafe ClanRoleEnum ClanRole
      {
        get
        {
          return *(ClanRoleEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_ClanRole));
        }
        [param: In] set
        {
          *(ClanRoleEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_ClanRole)) = value;
        }
      }

      public unsafe bool IsLocalPlayer
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_IsLocalPlayer));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_IsLocalPlayer)) = value;
        }
      }

      public unsafe bool IsOnline
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_IsOnline));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_MemberEntry.Data.NativeFieldInfoPtr_IsOnline)) = value;
        }
      }
    }
  }
}
