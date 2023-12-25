// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHUD_LevelComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterHUD_LevelComponent : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelText;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkullIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelDiffMotion;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterHUDSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_CachedLevelBackgroundGO;
    private static readonly System.IntPtr NativeFieldInfoPtr_CachedSkullIconGO;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentData;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1217805, RefRangeEnd = 1217807, XrefRangeStart = 1217735, XrefRangeEnd = 1217805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshData([In] ref CharacterHUD_LevelComponent.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_LevelComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUD_LevelComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_LevelComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHUD_LevelComponent()
    {
      Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterHUD_LevelComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr);
      CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, nameof (LevelText));
      CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, nameof (LevelBackground));
      CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, nameof (LevelImage));
      CharacterHUD_LevelComponent.NativeFieldInfoPtr_SkullIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, nameof (SkullIcon));
      CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelDiffMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, nameof (LevelDiffMotion));
      CharacterHUD_LevelComponent.NativeFieldInfoPtr_CharacterHUDSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, nameof (CharacterHUDSettings));
      CharacterHUD_LevelComponent.NativeFieldInfoPtr_CachedLevelBackgroundGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, nameof (CachedLevelBackgroundGO));
      CharacterHUD_LevelComponent.NativeFieldInfoPtr_CachedSkullIconGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, nameof (CachedSkullIconGO));
      CharacterHUD_LevelComponent.NativeFieldInfoPtr__CurrentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, nameof (_CurrentData));
      CharacterHUD_LevelComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, 100664334);
      CharacterHUD_LevelComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, 100664335);
    }

    public CharacterHUD_LevelComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText LevelText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image LevelBackground
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelBackground));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image LevelImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image SkullIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_SkullIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_SkullIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut LevelDiffMotion
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelDiffMotion));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_LevelDiffMotion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDSettings CharacterHUDSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_CharacterHUDSettings));
        return pointer == System.IntPtr.Zero ? (CharacterHUDSettings) null : new CharacterHUDSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_CharacterHUDSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject CachedLevelBackgroundGO
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_CachedLevelBackgroundGO));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_CachedLevelBackgroundGO), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject CachedSkullIconGO
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_CachedSkullIconGO));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr_CachedSkullIconGO), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<CharacterHUD_LevelComponent.Data> _CurrentData
    {
      get
      {
        return *(Nullable_Unboxed<CharacterHUD_LevelComponent.Data>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr__CurrentData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_LevelComponent.NativeFieldInfoPtr__CurrentData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<CharacterHUD_LevelComponent.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabType;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_LevelDiff;
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamSettings;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public CharacterHUDEntryType PrefabType;
      [FieldOffset(4)]
      public Nullable_Unboxed<float> LocalLevel;
      [FieldOffset(12)]
      public Nullable_Unboxed<float> EntityLevel;
      [FieldOffset(20)]
      public float LevelDiff;
      [FieldOffset(24)]
      public CharacterHUDSettings.TeamType TeamType;
      [FieldOffset(28)]
      public CharacterHUDSettings.TeamHUDSetting TeamSettings;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1217722, RefRangeEnd = 1217724, XrefRangeStart = 1217714, XrefRangeEnd = 1217722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(CharacterHUD_LevelComponent.Data other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_LevelComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217724, XrefRangeEnd = 1217728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_LevelComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217728, XrefRangeEnd = 1217735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_LevelComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Data()
      {
        Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHUD_LevelComponent>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr);
        CharacterHUD_LevelComponent.Data.NativeFieldInfoPtr_PrefabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr, nameof (PrefabType));
        CharacterHUD_LevelComponent.Data.NativeFieldInfoPtr_LocalLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr, nameof (LocalLevel));
        CharacterHUD_LevelComponent.Data.NativeFieldInfoPtr_EntityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr, nameof (EntityLevel));
        CharacterHUD_LevelComponent.Data.NativeFieldInfoPtr_LevelDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr, nameof (LevelDiff));
        CharacterHUD_LevelComponent.Data.NativeFieldInfoPtr_TeamType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr, nameof (TeamType));
        CharacterHUD_LevelComponent.Data.NativeFieldInfoPtr_TeamSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr, nameof (TeamSettings));
        CharacterHUD_LevelComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr, 100664336);
        CharacterHUD_LevelComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr, 100664337);
        CharacterHUD_LevelComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr, 100664338);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUD_LevelComponent.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
