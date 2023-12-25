// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHUD_HealthComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterHUD_HealthComponent : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Image;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecoveryImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecentDamageTakenImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthMotion;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterHUDSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTeamHUDSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentData;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1217689, RefRangeEnd = 1217691, XrefRangeStart = 1217659, XrefRangeEnd = 1217689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshData([In] ref CharacterHUD_HealthComponent.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_HealthComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUD_HealthComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_HealthComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHUD_HealthComponent()
    {
      Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterHUD_HealthComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr);
      CharacterHUD_HealthComponent.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, nameof (Image));
      CharacterHUD_HealthComponent.NativeFieldInfoPtr_AbsorbImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, nameof (AbsorbImage));
      CharacterHUD_HealthComponent.NativeFieldInfoPtr_FrameImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, nameof (FrameImage));
      CharacterHUD_HealthComponent.NativeFieldInfoPtr_RecoveryImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, nameof (RecoveryImage));
      CharacterHUD_HealthComponent.NativeFieldInfoPtr_RecentDamageTakenImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, nameof (RecentDamageTakenImage));
      CharacterHUD_HealthComponent.NativeFieldInfoPtr_HealthMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, nameof (HealthMotion));
      CharacterHUD_HealthComponent.NativeFieldInfoPtr_CharacterHUDSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, nameof (CharacterHUDSettings));
      CharacterHUD_HealthComponent.NativeFieldInfoPtr_CurrentTeamHUDSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, nameof (CurrentTeamHUDSettings));
      CharacterHUD_HealthComponent.NativeFieldInfoPtr__CurrentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, nameof (_CurrentData));
      CharacterHUD_HealthComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, 100664324);
      CharacterHUD_HealthComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, 100664325);
    }

    public CharacterHUD_HealthComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Image
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_Image));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image AbsorbImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_AbsorbImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_AbsorbImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image FrameImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_FrameImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_FrameImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image RecoveryImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_RecoveryImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_RecoveryImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image RecentDamageTakenImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_RecentDamageTakenImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_RecentDamageTakenImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut HealthMotion
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_HealthMotion));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_HealthMotion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDSettings CharacterHUDSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_CharacterHUDSettings));
        return pointer == System.IntPtr.Zero ? (CharacterHUDSettings) null : new CharacterHUDSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_CharacterHUDSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDSettings.TeamHUDSetting CurrentTeamHUDSettings
    {
      get
      {
        return *(CharacterHUDSettings.TeamHUDSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_CurrentTeamHUDSettings));
      }
      [param: In] set
      {
        *(CharacterHUDSettings.TeamHUDSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr_CurrentTeamHUDSettings)) = value;
      }
    }

    public unsafe Nullable_Unboxed<CharacterHUD_HealthComponent.Data> _CurrentData
    {
      get
      {
        return *(Nullable_Unboxed<CharacterHUD_HealthComponent.Data>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr__CurrentData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_HealthComponent.NativeFieldInfoPtr__CurrentData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<CharacterHUD_HealthComponent.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_RecentDamageTakenFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_RecoveryFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsVampireHunter;
      private static readonly System.IntPtr NativeFieldInfoPtr_LevelDiff;
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamSettings;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public float HealthFill;
      [FieldOffset(4)]
      public float AbsorbFill;
      [FieldOffset(8)]
      public float RecentDamageTakenFill;
      [FieldOffset(12)]
      public float RecoveryFill;
      [FieldOffset(16)]
      public bool IsVampireHunter;
      [FieldOffset(20)]
      public float LevelDiff;
      [FieldOffset(24)]
      public CharacterHUDSettings.TeamHUDSetting TeamSettings;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1217646, RefRangeEnd = 1217648, XrefRangeStart = 1217639, XrefRangeEnd = 1217646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(CharacterHUD_HealthComponent.Data other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_HealthComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217648, XrefRangeEnd = 1217652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_HealthComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217652, XrefRangeEnd = 1217659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_HealthComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Data()
      {
        Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHUD_HealthComponent>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr);
        CharacterHUD_HealthComponent.Data.NativeFieldInfoPtr_HealthFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr, nameof (HealthFill));
        CharacterHUD_HealthComponent.Data.NativeFieldInfoPtr_AbsorbFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr, nameof (AbsorbFill));
        CharacterHUD_HealthComponent.Data.NativeFieldInfoPtr_RecentDamageTakenFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr, nameof (RecentDamageTakenFill));
        CharacterHUD_HealthComponent.Data.NativeFieldInfoPtr_RecoveryFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr, nameof (RecoveryFill));
        CharacterHUD_HealthComponent.Data.NativeFieldInfoPtr_IsVampireHunter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr, nameof (IsVampireHunter));
        CharacterHUD_HealthComponent.Data.NativeFieldInfoPtr_LevelDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr, nameof (LevelDiff));
        CharacterHUD_HealthComponent.Data.NativeFieldInfoPtr_TeamSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr, nameof (TeamSettings));
        CharacterHUD_HealthComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr, 100664326);
        CharacterHUD_HealthComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr, 100664327);
        CharacterHUD_HealthComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr, 100664328);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUD_HealthComponent.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
