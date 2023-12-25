// Decompiled with JetBrains decompiler
// Type: ProjectM.DropInInventoryOnSpawnAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class DropInInventoryOnSpawnAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DropTrigger;
    private static readonly IntPtr NativeFieldInfoPtr_ReplaceInventory;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013145, XrefRangeEnd = 1013148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(DropInInventoryOnSpawnAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DropInInventoryOnSpawnAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropInInventoryOnSpawnAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropInInventoryOnSpawnAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DropInInventoryOnSpawnAuthoring()
    {
      Il2CppClassPointerStore<DropInInventoryOnSpawnAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropInInventoryOnSpawnAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInInventoryOnSpawnAuthoring>.NativeClassPtr);
      DropInInventoryOnSpawnAuthoring.NativeFieldInfoPtr_DropTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInInventoryOnSpawnAuthoring>.NativeClassPtr, nameof (DropTrigger));
      DropInInventoryOnSpawnAuthoring.NativeFieldInfoPtr_ReplaceInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInInventoryOnSpawnAuthoring>.NativeClassPtr, nameof (ReplaceInventory));
      DropInInventoryOnSpawnAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInInventoryOnSpawnAuthoring>.NativeClassPtr, 100678970);
      DropInInventoryOnSpawnAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInInventoryOnSpawnAuthoring>.NativeClassPtr, 100678971);
    }

    public DropInInventoryOnSpawnAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe DropTriggerType DropTrigger
    {
      get
      {
        return *(DropTriggerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryOnSpawnAuthoring.NativeFieldInfoPtr_DropTrigger));
      }
      [param: In] set
      {
        *(DropTriggerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryOnSpawnAuthoring.NativeFieldInfoPtr_DropTrigger)) = value;
      }
    }

    public unsafe bool ReplaceInventory
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryOnSpawnAuthoring.NativeFieldInfoPtr_ReplaceInventory));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryOnSpawnAuthoring.NativeFieldInfoPtr_ReplaceInventory)) = value;
      }
    }
  }
}
