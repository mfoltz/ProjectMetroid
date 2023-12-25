// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHUD_PvPProtectionComponent
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
  public class CharacterHUD_PvPProtectionComponent : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CachedPvPProtectionIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentData;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1217919, RefRangeEnd = 1217920, XrefRangeStart = 1217910, XrefRangeEnd = 1217919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshData([In] ref CharacterHUD_PvPProtectionComponent.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_PvPProtectionComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUD_PvPProtectionComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_PvPProtectionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHUD_PvPProtectionComponent()
    {
      Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterHUD_PvPProtectionComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent>.NativeClassPtr);
      CharacterHUD_PvPProtectionComponent.NativeFieldInfoPtr_PvPProtection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent>.NativeClassPtr, nameof (PvPProtection));
      CharacterHUD_PvPProtectionComponent.NativeFieldInfoPtr_CachedPvPProtectionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent>.NativeClassPtr, nameof (CachedPvPProtectionIcon));
      CharacterHUD_PvPProtectionComponent.NativeFieldInfoPtr__CurrentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent>.NativeClassPtr, nameof (_CurrentData));
      CharacterHUD_PvPProtectionComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent>.NativeClassPtr, 100664354);
      CharacterHUD_PvPProtectionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent>.NativeClassPtr, 100664355);
    }

    public CharacterHUD_PvPProtectionComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image PvPProtection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_PvPProtectionComponent.NativeFieldInfoPtr_PvPProtection));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_PvPProtectionComponent.NativeFieldInfoPtr_PvPProtection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject CachedPvPProtectionIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_PvPProtectionComponent.NativeFieldInfoPtr_CachedPvPProtectionIcon));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_PvPProtectionComponent.NativeFieldInfoPtr_CachedPvPProtectionIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<CharacterHUD_PvPProtectionComponent.Data> _CurrentData
    {
      get
      {
        return *(Nullable_Unboxed<CharacterHUD_PvPProtectionComponent.Data>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_PvPProtectionComponent.NativeFieldInfoPtr__CurrentData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_PvPProtectionComponent.NativeFieldInfoPtr__CurrentData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<CharacterHUD_PvPProtectionComponent.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IsPvPProtected;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public bool IsPvPProtected;

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 731961, RefRangeEnd = 731976, XrefRangeStart = 731961, XrefRangeEnd = 731976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(CharacterHUD_PvPProtectionComponent.Data other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_PvPProtectionComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217907, XrefRangeEnd = 1217910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_PvPProtectionComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_PvPProtectionComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Data()
      {
        Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent.Data>.NativeClassPtr);
        CharacterHUD_PvPProtectionComponent.Data.NativeFieldInfoPtr_IsPvPProtected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent.Data>.NativeClassPtr, nameof (IsPvPProtected));
        CharacterHUD_PvPProtectionComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent.Data>.NativeClassPtr, 100664356);
        CharacterHUD_PvPProtectionComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent.Data>.NativeClassPtr, 100664357);
        CharacterHUD_PvPProtectionComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent.Data>.NativeClassPtr, 100664358);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUD_PvPProtectionComponent.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
