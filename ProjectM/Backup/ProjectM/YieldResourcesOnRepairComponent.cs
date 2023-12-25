// Decompiled with JetBrains decompiler
// Type: ProjectM.YieldResourcesOnRepairComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class YieldResourcesOnRepairComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Resources;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009056, XrefRangeEnd = 1009069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(YieldResourcesOnRepairComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe YieldResourcesOnRepairComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YieldResourcesOnRepairComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(YieldResourcesOnRepairComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static YieldResourcesOnRepairComponent()
    {
      Il2CppClassPointerStore<YieldResourcesOnRepairComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (YieldResourcesOnRepairComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldResourcesOnRepairComponent>.NativeClassPtr);
      YieldResourcesOnRepairComponent.NativeFieldInfoPtr_Resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldResourcesOnRepairComponent>.NativeClassPtr, nameof (Resources));
      YieldResourcesOnRepairComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldResourcesOnRepairComponent>.NativeClassPtr, 100678429);
      YieldResourcesOnRepairComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldResourcesOnRepairComponent>.NativeClassPtr, 100678430);
    }

    public YieldResourcesOnRepairComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe YieldResourcesOnRepairComponent.YieldResourceOnDamageTakenArray Resources
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldResourcesOnRepairComponent.NativeFieldInfoPtr_Resources));
        return pointer == IntPtr.Zero ? (YieldResourcesOnRepairComponent.YieldResourceOnDamageTakenArray) null : new YieldResourcesOnRepairComponent.YieldResourceOnDamageTakenArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(YieldResourcesOnRepairComponent.NativeFieldInfoPtr_Resources), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class YieldResourceOnDamageTakenArray : ReorderableArray<YieldResourcesOnRepair>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009045, XrefRangeEnd = 1009056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe YieldResourceOnDamageTakenArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YieldResourcesOnRepairComponent.YieldResourceOnDamageTakenArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(YieldResourcesOnRepairComponent.YieldResourceOnDamageTakenArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static YieldResourceOnDamageTakenArray()
      {
        Il2CppClassPointerStore<YieldResourcesOnRepairComponent.YieldResourceOnDamageTakenArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YieldResourcesOnRepairComponent>.NativeClassPtr, nameof (YieldResourceOnDamageTakenArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldResourcesOnRepairComponent.YieldResourceOnDamageTakenArray>.NativeClassPtr);
        YieldResourcesOnRepairComponent.YieldResourceOnDamageTakenArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldResourcesOnRepairComponent.YieldResourceOnDamageTakenArray>.NativeClassPtr, 100678431);
      }

      public YieldResourceOnDamageTakenArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
