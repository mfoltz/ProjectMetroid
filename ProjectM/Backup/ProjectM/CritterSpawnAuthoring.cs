// Decompiled with JetBrains decompiler
// Type: ProjectM.CritterSpawnAuthoring
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
  public class CritterSpawnAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SpawnableCritters;
    private static readonly IntPtr NativeFieldInfoPtr_CritterSpawnAreaStartDist;
    private static readonly IntPtr NativeFieldInfoPtr_CritterSpawnAreaEndDist;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988099, XrefRangeEnd = 988131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CritterSpawnAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmosSelected()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSpawnAuthoring.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988131, XrefRangeEnd = 988132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CritterSpawnAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterSpawnAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSpawnAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CritterSpawnAuthoring()
    {
      Il2CppClassPointerStore<CritterSpawnAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CritterSpawnAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSpawnAuthoring>.NativeClassPtr);
      CritterSpawnAuthoring.NativeFieldInfoPtr_SpawnableCritters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawnAuthoring>.NativeClassPtr, nameof (SpawnableCritters));
      CritterSpawnAuthoring.NativeFieldInfoPtr_CritterSpawnAreaStartDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawnAuthoring>.NativeClassPtr, nameof (CritterSpawnAreaStartDist));
      CritterSpawnAuthoring.NativeFieldInfoPtr_CritterSpawnAreaEndDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSpawnAuthoring>.NativeClassPtr, nameof (CritterSpawnAreaEndDist));
      CritterSpawnAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSpawnAuthoring>.NativeClassPtr, 100676203);
      CritterSpawnAuthoring.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSpawnAuthoring>.NativeClassPtr, 100676204);
      CritterSpawnAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSpawnAuthoring>.NativeClassPtr, 100676205);
    }

    public CritterSpawnAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<CritterGroupAuthoring> SpawnableCritters
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawnAuthoring.NativeFieldInfoPtr_SpawnableCritters));
        return pointer == IntPtr.Zero ? (List<CritterGroupAuthoring>) null : new List<CritterGroupAuthoring>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawnAuthoring.NativeFieldInfoPtr_SpawnableCritters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float CritterSpawnAreaStartDist
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawnAuthoring.NativeFieldInfoPtr_CritterSpawnAreaStartDist));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawnAuthoring.NativeFieldInfoPtr_CritterSpawnAreaStartDist)) = value;
      }
    }

    public unsafe float CritterSpawnAreaEndDist
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawnAuthoring.NativeFieldInfoPtr_CritterSpawnAreaEndDist));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSpawnAuthoring.NativeFieldInfoPtr_CritterSpawnAreaEndDist)) = value;
      }
    }
  }
}
