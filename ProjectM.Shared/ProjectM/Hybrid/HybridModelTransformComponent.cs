// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelTransformComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridModelTransformComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Transform;
    private static readonly IntPtr NativeFieldInfoPtr_IsPlayer;
    private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796719, XrefRangeEnd = 796735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddComponent(
      World world,
      PrefabLookupMap prefabLookupMap,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &prefabLookupMap;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &hybridEntity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelTransformComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796735, XrefRangeEnd = 796741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasContentErrors()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelTransformComponent.NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796741, XrefRangeEnd = 796743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelTransformComponent.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridModelTransformComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelTransformComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelTransformComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridModelTransformComponent()
    {
      Il2CppClassPointerStore<HybridModelTransformComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (HybridModelTransformComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelTransformComponent>.NativeClassPtr);
      HybridModelTransformComponent.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelTransformComponent>.NativeClassPtr, nameof (Transform));
      HybridModelTransformComponent.NativeFieldInfoPtr_IsPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelTransformComponent>.NativeClassPtr, nameof (IsPlayer));
      HybridModelTransformComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelTransformComponent>.NativeClassPtr, 100670297);
      HybridModelTransformComponent.NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelTransformComponent>.NativeClassPtr, 100670298);
      HybridModelTransformComponent.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelTransformComponent>.NativeClassPtr, 100670299);
      HybridModelTransformComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelTransformComponent>.NativeClassPtr, 100670300);
    }

    public HybridModelTransformComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Transform Transform
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelTransformComponent.NativeFieldInfoPtr_Transform));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelTransformComponent.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsPlayer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelTransformComponent.NativeFieldInfoPtr_IsPlayer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelTransformComponent.NativeFieldInfoPtr_IsPlayer)) = value;
      }
    }
  }
}
