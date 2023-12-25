// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHUD_ProgressBarComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using StunShared.UI;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterHUD_ProgressBarComponent : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBarParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBar;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBarGlow;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBarText;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBarMotion;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentData;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_EntityManager_PrefabLookupMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1217906, RefRangeEnd = 1217907, XrefRangeStart = 1217884, XrefRangeEnd = 1217906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshData(
      [In] ref CharacterHUD_ProgressBarComponent.Data data,
      EntityManager entityManager,
      PrefabLookupMap prefabLookupMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_ProgressBarComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_EntityManager_PrefabLookupMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUD_ProgressBarComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_ProgressBarComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHUD_ProgressBarComponent()
    {
      Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterHUD_ProgressBarComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr);
      CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr, nameof (ProgressBarParent));
      CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr, nameof (ProgressBar));
      CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr, nameof (ProgressBarGlow));
      CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr, nameof (ProgressBarText));
      CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr, nameof (ProgressBarMotion));
      CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr__CurrentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr, nameof (_CurrentData));
      CharacterHUD_ProgressBarComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_EntityManager_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr, 100664349);
      CharacterHUD_ProgressBarComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr, 100664350);
    }

    public CharacterHUD_ProgressBarComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject ProgressBarParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarParent));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ProgressBar
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBar));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ProgressBarGlow
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarGlow));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarGlow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ProgressBarText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut ProgressBarMotion
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarMotion));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr_ProgressBarMotion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<CharacterHUD_ProgressBarComponent.Data> _CurrentData
    {
      get
      {
        return *(Nullable_Unboxed<CharacterHUD_ProgressBarComponent.Data>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr__CurrentData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_ProgressBarComponent.NativeFieldInfoPtr__CurrentData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<CharacterHUD_ProgressBarComponent.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBarTypeId;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBarPercentage;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public Nullable_Unboxed<int> ProgressBarTypeId;
      [FieldOffset(8)]
      public float ProgressBarPercentage;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1217873, RefRangeEnd = 1217874, XrefRangeStart = 1217871, XrefRangeEnd = 1217873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(CharacterHUD_ProgressBarComponent.Data other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_ProgressBarComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217874, XrefRangeEnd = 1217880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_ProgressBarComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217880, XrefRangeEnd = 1217884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_ProgressBarComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Data()
      {
        Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent.Data>.NativeClassPtr);
        CharacterHUD_ProgressBarComponent.Data.NativeFieldInfoPtr_ProgressBarTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent.Data>.NativeClassPtr, nameof (ProgressBarTypeId));
        CharacterHUD_ProgressBarComponent.Data.NativeFieldInfoPtr_ProgressBarPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent.Data>.NativeClassPtr, nameof (ProgressBarPercentage));
        CharacterHUD_ProgressBarComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent.Data>.NativeClassPtr, 100664351);
        CharacterHUD_ProgressBarComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent.Data>.NativeClassPtr, 100664352);
        CharacterHUD_ProgressBarComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent.Data>.NativeClassPtr, 100664353);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUD_ProgressBarComponent.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
