// Decompiled with JetBrains decompiler
// Type: ProjectM.YieldResourcesOnPickupComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class YieldResourcesOnPickupComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_YieldResources;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_FillTree_Public_Virtual_Final_New_Void_ChunkSummaryBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009004, XrefRangeEnd = 1009033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(YieldResourcesOnPickupComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009033, XrefRangeEnd = 1009045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void FillTree(ChunkSummaryBuilder summary)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) summary);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(YieldResourcesOnPickupComponent.NativeMethodInfoPtr_FillTree_Public_Virtual_Final_New_Void_ChunkSummaryBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe YieldResourcesOnPickupComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YieldResourcesOnPickupComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(YieldResourcesOnPickupComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static YieldResourcesOnPickupComponent()
    {
      Il2CppClassPointerStore<YieldResourcesOnPickupComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (YieldResourcesOnPickupComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldResourcesOnPickupComponent>.NativeClassPtr);
      YieldResourcesOnPickupComponent.NativeFieldInfoPtr_YieldResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldResourcesOnPickupComponent>.NativeClassPtr, nameof (YieldResources));
      YieldResourcesOnPickupComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldResourcesOnPickupComponent>.NativeClassPtr, 100678425);
      YieldResourcesOnPickupComponent.NativeMethodInfoPtr_FillTree_Public_Virtual_Final_New_Void_ChunkSummaryBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldResourcesOnPickupComponent>.NativeClassPtr, 100678426);
      YieldResourcesOnPickupComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldResourcesOnPickupComponent>.NativeClassPtr, 100678427);
    }

    public YieldResourcesOnPickupComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe YieldResourcesOnPickupComponent.YieldResourceOnDamageTakenArray_Editor YieldResources
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldResourcesOnPickupComponent.NativeFieldInfoPtr_YieldResources));
        return pointer == IntPtr.Zero ? (YieldResourcesOnPickupComponent.YieldResourceOnDamageTakenArray_Editor) null : new YieldResourcesOnPickupComponent.YieldResourceOnDamageTakenArray_Editor(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(YieldResourcesOnPickupComponent.NativeFieldInfoPtr_YieldResources), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class YieldResourceOnDamageTakenArray_Editor : 
      ReorderableArray<YieldResourcesOnPickup_Editor>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009001, XrefRangeEnd = 1009004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe YieldResourceOnDamageTakenArray_Editor()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YieldResourcesOnPickupComponent.YieldResourceOnDamageTakenArray_Editor>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(YieldResourcesOnPickupComponent.YieldResourceOnDamageTakenArray_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static YieldResourceOnDamageTakenArray_Editor()
      {
        Il2CppClassPointerStore<YieldResourcesOnPickupComponent.YieldResourceOnDamageTakenArray_Editor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YieldResourcesOnPickupComponent>.NativeClassPtr, nameof (YieldResourceOnDamageTakenArray_Editor));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldResourcesOnPickupComponent.YieldResourceOnDamageTakenArray_Editor>.NativeClassPtr);
        YieldResourcesOnPickupComponent.YieldResourceOnDamageTakenArray_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldResourcesOnPickupComponent.YieldResourceOnDamageTakenArray_Editor>.NativeClassPtr, 100678428);
      }

      public YieldResourceOnDamageTakenArray_Editor(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
