// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHUD_NameComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Collections;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterHUD_NameComponent : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterHUDSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameMotion;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentNameFixedString64;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedName;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Boolean_byref_Data_byref_TeamHUDSetting_TextFilterer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1217870, RefRangeEnd = 1217871, XrefRangeStart = 1217838, XrefRangeEnd = 1217870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool RefreshData(
      [In] ref CharacterHUD_NameComponent.Data data,
      [In] ref CharacterHUDSettings.TeamHUDSetting teamSettings,
      TextFilterer textFilterer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref teamSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) textFilterer));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_NameComponent.NativeMethodInfoPtr_RefreshData_Public_Boolean_byref_Data_byref_TeamHUDSetting_TextFilterer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUD_NameComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHUD_NameComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_NameComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHUD_NameComponent()
    {
      Il2CppClassPointerStore<CharacterHUD_NameComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterHUD_NameComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_NameComponent>.NativeClassPtr);
      CharacterHUD_NameComponent.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_NameComponent>.NativeClassPtr, nameof (Text));
      CharacterHUD_NameComponent.NativeFieldInfoPtr_CharacterHUDSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_NameComponent>.NativeClassPtr, nameof (CharacterHUDSettings));
      CharacterHUD_NameComponent.NativeFieldInfoPtr_NameMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_NameComponent>.NativeClassPtr, nameof (NameMotion));
      CharacterHUD_NameComponent.NativeFieldInfoPtr__CurrentNameFixedString64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_NameComponent>.NativeClassPtr, nameof (_CurrentNameFixedString64));
      CharacterHUD_NameComponent.NativeFieldInfoPtr__CachedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_NameComponent>.NativeClassPtr, nameof (_CachedName));
      CharacterHUD_NameComponent.NativeMethodInfoPtr_RefreshData_Public_Boolean_byref_Data_byref_TeamHUDSetting_TextFilterer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_NameComponent>.NativeClassPtr, 100664344);
      CharacterHUD_NameComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_NameComponent>.NativeClassPtr, 100664345);
    }

    public CharacterHUD_NameComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TextMeshProUGUI Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_NameComponent.NativeFieldInfoPtr_Text));
        return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_NameComponent.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDSettings CharacterHUDSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_NameComponent.NativeFieldInfoPtr_CharacterHUDSettings));
        return pointer == System.IntPtr.Zero ? (CharacterHUDSettings) null : new CharacterHUDSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_NameComponent.NativeFieldInfoPtr_CharacterHUDSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut NameMotion
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_NameComponent.NativeFieldInfoPtr_NameMotion));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_NameComponent.NativeFieldInfoPtr_NameMotion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FixedString64 _CurrentNameFixedString64
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_NameComponent.NativeFieldInfoPtr__CurrentNameFixedString64));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_NameComponent.NativeFieldInfoPtr__CurrentNameFixedString64)) = value;
      }
    }

    public unsafe string _CachedName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_NameComponent.NativeFieldInfoPtr__CachedName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_NameComponent.NativeFieldInfoPtr__CachedName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedName;
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamType;
      private static readonly System.IntPtr NativeFieldInfoPtr_LevelDiff;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public FixedString64 Name;
      [FieldOffset(64)]
      public AssetGuid LocalizedName;
      [FieldOffset(80)]
      public CharacterHUDSettings.TeamType TeamType;
      [FieldOffset(84)]
      public float LevelDiff;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1217830, RefRangeEnd = 1217831, XrefRangeStart = 1217826, XrefRangeEnd = 1217830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(CharacterHUD_NameComponent.Data other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_NameComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217831, XrefRangeEnd = 1217835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_NameComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217835, XrefRangeEnd = 1217838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_NameComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Data()
      {
        Il2CppClassPointerStore<CharacterHUD_NameComponent.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHUD_NameComponent>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_NameComponent.Data>.NativeClassPtr);
        CharacterHUD_NameComponent.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_NameComponent.Data>.NativeClassPtr, nameof (Name));
        CharacterHUD_NameComponent.Data.NativeFieldInfoPtr_LocalizedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_NameComponent.Data>.NativeClassPtr, nameof (LocalizedName));
        CharacterHUD_NameComponent.Data.NativeFieldInfoPtr_TeamType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_NameComponent.Data>.NativeClassPtr, nameof (TeamType));
        CharacterHUD_NameComponent.Data.NativeFieldInfoPtr_LevelDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_NameComponent.Data>.NativeClassPtr, nameof (LevelDiff));
        CharacterHUD_NameComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_NameComponent.Data>.NativeClassPtr, 100664346);
        CharacterHUD_NameComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_NameComponent.Data>.NativeClassPtr, 100664347);
        CharacterHUD_NameComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_NameComponent.Data>.NativeClassPtr, 100664348);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUD_NameComponent.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
