// Decompiled with JetBrains decompiler
// Type: ProjectM.ConsumableComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ConsumableComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Conditions;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 989373, RefRangeEnd = 989374, XrefRangeStart = 989355, XrefRangeEnd = 989373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(Entity entity, EntityManager dstManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsumableComponent.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConsumableComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsumableComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsumableComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConsumableComponent()
    {
      Il2CppClassPointerStore<ConsumableComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ConsumableComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsumableComponent>.NativeClassPtr);
      ConsumableComponent.NativeFieldInfoPtr_Conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumableComponent>.NativeClassPtr, nameof (Conditions));
      ConsumableComponent.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumableComponent>.NativeClassPtr, 100676348);
      ConsumableComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumableComponent>.NativeClassPtr, 100676349);
    }

    public ConsumableComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<ConsumableCondition_Editor> Conditions
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsumableComponent.NativeFieldInfoPtr_Conditions));
        return pointer == IntPtr.Zero ? (List<ConsumableCondition_Editor>) null : new List<ConsumableCondition_Editor>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConsumableComponent.NativeFieldInfoPtr_Conditions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
