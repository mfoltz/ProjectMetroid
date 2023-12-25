// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SocialMenu_MemberEntry
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
  public class SocialMenu_MemberEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlatformId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Motion;
    private static readonly System.IntPtr NativeFieldInfoPtr_MutedIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeakingIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChatMutedIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Status_Muted;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Status_Speaking;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserPlatformId;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_SocialMenu_MemberEntry_Data_GridSelectionGroup_2_SocialMenu_MemberEntry_Data_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1233148, RefRangeEnd = 1233149, XrefRangeStart = 1233129, XrefRangeEnd = 1233148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(
      SocialMenu_MemberEntry entry,
      SocialMenu_MemberEntry.Data data,
      GridSelectionGroup<SocialMenu_MemberEntry, SocialMenu_MemberEntry.Data> parent,
      bool showPanel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &showPanel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SocialMenu_MemberEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_SocialMenu_MemberEntry_Data_GridSelectionGroup_2_SocialMenu_MemberEntry_Data_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SocialMenu_MemberEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SocialMenu_MemberEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SocialMenu_MemberEntry()
    {
      Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SocialMenu_MemberEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr);
      SocialMenu_MemberEntry.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (CanvasGroup));
      SocialMenu_MemberEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (Name));
      SocialMenu_MemberEntry.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (Status));
      SocialMenu_MemberEntry.NativeFieldInfoPtr_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (PlatformId));
      SocialMenu_MemberEntry.NativeFieldInfoPtr_Motion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (Motion));
      SocialMenu_MemberEntry.NativeFieldInfoPtr_MutedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (MutedIcon));
      SocialMenu_MemberEntry.NativeFieldInfoPtr_SpeakingIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (SpeakingIcon));
      SocialMenu_MemberEntry.NativeFieldInfoPtr_ChatMutedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (ChatMutedIcon));
      SocialMenu_MemberEntry.NativeFieldInfoPtr_LKey_Status_Muted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (LKey_Status_Muted));
      SocialMenu_MemberEntry.NativeFieldInfoPtr_LKey_Status_Speaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (LKey_Status_Speaking));
      SocialMenu_MemberEntry.NativeFieldInfoPtr_UserPlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (UserPlatformId));
      SocialMenu_MemberEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_SocialMenu_MemberEntry_Data_GridSelectionGroup_2_SocialMenu_MemberEntry_Data_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, 100665557);
      SocialMenu_MemberEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, 100665558);
    }

    public SocialMenu_MemberEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CanvasGroup CanvasGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_CanvasGroup));
        return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_Name));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Status
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_Status));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_Status), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PlatformId
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_PlatformId));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_PlatformId), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut Motion
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_Motion));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_Motion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image MutedIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_MutedIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_MutedIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image SpeakingIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_SpeakingIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_SpeakingIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ChatMutedIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_ChatMutedIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_ChatMutedIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Status_Muted
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_LKey_Status_Muted));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_LKey_Status_Muted)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Status_Speaking
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_LKey_Status_Speaking));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_LKey_Status_Speaking)) = value;
      }
    }

    public unsafe ulong UserPlatformId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_UserPlatformId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.NativeFieldInfoPtr_UserPlatformId)) = value;
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PlatformId;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSpeaking;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsMuted;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsChatMuted;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsStreamerMode;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Data_0;

      [CallerCount(0)]
      public virtual unsafe int CompareTo(SocialMenu_MemberEntry.Data other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SocialMenu_MemberEntry.Data.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Data_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Data()
      {
        Il2CppClassPointerStore<SocialMenu_MemberEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocialMenu_MemberEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialMenu_MemberEntry.Data>.NativeClassPtr);
        SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry.Data>.NativeClassPtr, nameof (PlatformId));
        SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry.Data>.NativeClassPtr, nameof (Name));
        SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsSpeaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry.Data>.NativeClassPtr, nameof (IsSpeaking));
        SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsMuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry.Data>.NativeClassPtr, nameof (IsMuted));
        SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsChatMuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry.Data>.NativeClassPtr, nameof (IsChatMuted));
        SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsStreamerMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu_MemberEntry.Data>.NativeClassPtr, nameof (IsStreamerMode));
        SocialMenu_MemberEntry.Data.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialMenu_MemberEntry.Data>.NativeClassPtr, 100665559);
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SocialMenu_MemberEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SocialMenu_MemberEntry.Data>.NativeClassPtr, data));
      }

      public unsafe ulong PlatformId
      {
        get
        {
          return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_PlatformId));
        }
        [param: In] set
        {
          *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_PlatformId)) = value;
        }
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe bool IsSpeaking
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsSpeaking));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsSpeaking)) = value;
        }
      }

      public unsafe bool IsMuted
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsMuted));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsMuted)) = value;
        }
      }

      public unsafe bool IsChatMuted
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsChatMuted));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsChatMuted)) = value;
        }
      }

      public unsafe bool IsStreamerMode
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsStreamerMode));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu_MemberEntry.Data.NativeFieldInfoPtr_IsStreamerMode)) = value;
        }
      }
    }
  }
}
