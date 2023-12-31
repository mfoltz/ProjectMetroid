// Decompiled with JetBrains decompiler
// Type: ProjectM.PatrolAuthoring
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
namespace ProjectM
{
  public class PatrolAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Formation;
    private static readonly IntPtr NativeFieldInfoPtr_Type;
    private static readonly IntPtr NativeFieldInfoPtr_Path;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnData;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(PatrolAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PatrolAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PatrolAuthoring()
    {
      Il2CppClassPointerStore<PatrolAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PatrolAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolAuthoring>.NativeClassPtr);
      PatrolAuthoring.NativeFieldInfoPtr_Formation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolAuthoring>.NativeClassPtr, nameof (Formation));
      PatrolAuthoring.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolAuthoring>.NativeClassPtr, nameof (Type));
      PatrolAuthoring.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolAuthoring>.NativeClassPtr, nameof (Path));
      PatrolAuthoring.NativeFieldInfoPtr_SpawnData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolAuthoring>.NativeClassPtr, nameof (SpawnData));
      PatrolAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolAuthoring>.NativeClassPtr, 100665812);
      PatrolAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolAuthoring>.NativeClassPtr, 100665813);
    }

    public PatrolAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnitFormationAuthoring Formation
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolAuthoring.NativeFieldInfoPtr_Formation));
        return pointer == IntPtr.Zero ? (UnitFormationAuthoring) null : new UnitFormationAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolAuthoring.NativeFieldInfoPtr_Formation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PatrolType Type
    {
      get
      {
        return *(PatrolType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolAuthoring.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(PatrolType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolAuthoring.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe PathAuthoring Path
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolAuthoring.NativeFieldInfoPtr_Path));
        return pointer == IntPtr.Zero ? (PathAuthoring) null : new PathAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolAuthoring.NativeFieldInfoPtr_Path), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PatrolSpawnData SpawnData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolAuthoring.NativeFieldInfoPtr_SpawnData));
        return pointer == IntPtr.Zero ? (PatrolSpawnData) null : new PatrolSpawnData(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolAuthoring.NativeFieldInfoPtr_SpawnData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
