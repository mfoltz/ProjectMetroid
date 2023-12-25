// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHUD_ServantComponent
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
  public class CharacterHUD_ServantComponent : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantInventoryIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CachedServantInventoryIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentData;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_ManagedDataRegistry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1217936, RefRangeEnd = 1217937, XrefRangeStart = 1217923, XrefRangeEnd = 1217936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshData(
      [In] ref CharacterHUD_ServantComponent.Data data,
      ManagedDataRegistry managedDataRegistry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) managedDataRegistry));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_ServantComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_ManagedDataRegistry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUD_ServantComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHUD_ServantComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_ServantComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHUD_ServantComponent()
    {
      Il2CppClassPointerStore<CharacterHUD_ServantComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterHUD_ServantComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_ServantComponent>.NativeClassPtr);
      CharacterHUD_ServantComponent.NativeFieldInfoPtr_ServantInventoryIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ServantComponent>.NativeClassPtr, nameof (ServantInventoryIcon));
      CharacterHUD_ServantComponent.NativeFieldInfoPtr_CachedServantInventoryIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ServantComponent>.NativeClassPtr, nameof (CachedServantInventoryIcon));
      CharacterHUD_ServantComponent.NativeFieldInfoPtr__CurrentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ServantComponent>.NativeClassPtr, nameof (_CurrentData));
      CharacterHUD_ServantComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_ManagedDataRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_ServantComponent>.NativeClassPtr, 100664359);
      CharacterHUD_ServantComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_ServantComponent>.NativeClassPtr, 100664360);
    }

    public CharacterHUD_ServantComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image ServantInventoryIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ServantComponent.NativeFieldInfoPtr_ServantInventoryIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ServantComponent.NativeFieldInfoPtr_ServantInventoryIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject CachedServantInventoryIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ServantComponent.NativeFieldInfoPtr_CachedServantInventoryIcon));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ServantComponent.NativeFieldInfoPtr_CachedServantInventoryIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<CharacterHUD_ServantComponent.Data> _CurrentData
    {
      get
      {
        return *(Nullable_Unboxed<CharacterHUD_ServantComponent.Data>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ServantComponent.NativeFieldInfoPtr__CurrentData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ServantComponent.NativeFieldInfoPtr__CurrentData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<CharacterHUD_ServantComponent.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IsServantWithItems;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public bool IsServantWithItems;

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 731961, RefRangeEnd = 731976, XrefRangeStart = 731961, XrefRangeEnd = 731976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(CharacterHUD_ServantComponent.Data other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_ServantComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217920, XrefRangeEnd = 1217923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_ServantComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_ServantComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Data()
      {
        Il2CppClassPointerStore<CharacterHUD_ServantComponent.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHUD_ServantComponent>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_ServantComponent.Data>.NativeClassPtr);
        CharacterHUD_ServantComponent.Data.NativeFieldInfoPtr_IsServantWithItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ServantComponent.Data>.NativeClassPtr, nameof (IsServantWithItems));
        CharacterHUD_ServantComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_ServantComponent.Data>.NativeClassPtr, 100664361);
        CharacterHUD_ServantComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_ServantComponent.Data>.NativeClassPtr, 100664362);
        CharacterHUD_ServantComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_ServantComponent.Data>.NativeClassPtr, 100664363);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUD_ServantComponent.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
