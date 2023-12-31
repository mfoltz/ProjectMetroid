// Decompiled with JetBrains decompiler
// Type: ProjectM.NetherSpawnPositionAuthoring
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
  public class NetherSpawnPositionAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_NetherSpawnCoffinPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_GizmoHeight;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727436, XrefRangeEnd = 727440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(NetherSpawnPositionAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727440, XrefRangeEnd = 727452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetherSpawnPositionAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727452, XrefRangeEnd = 727469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmosSelected()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetherSpawnPositionAuthoring.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetherSpawnPositionAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetherSpawnPositionAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetherSpawnPositionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetherSpawnPositionAuthoring()
    {
      Il2CppClassPointerStore<NetherSpawnPositionAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (NetherSpawnPositionAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetherSpawnPositionAuthoring>.NativeClassPtr);
      NetherSpawnPositionAuthoring.NativeFieldInfoPtr_NetherSpawnCoffinPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionAuthoring>.NativeClassPtr, nameof (NetherSpawnCoffinPrefab));
      NetherSpawnPositionAuthoring.NativeFieldInfoPtr_GizmoHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionAuthoring>.NativeClassPtr, nameof (GizmoHeight));
      NetherSpawnPositionAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetherSpawnPositionAuthoring>.NativeClassPtr, 100664377);
      NetherSpawnPositionAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetherSpawnPositionAuthoring>.NativeClassPtr, 100664378);
      NetherSpawnPositionAuthoring.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetherSpawnPositionAuthoring>.NativeClassPtr, 100664379);
      NetherSpawnPositionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetherSpawnPositionAuthoring>.NativeClassPtr, 100664380);
    }

    public NetherSpawnPositionAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent NetherSpawnCoffinPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetherSpawnPositionAuthoring.NativeFieldInfoPtr_NetherSpawnCoffinPrefab));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NetherSpawnPositionAuthoring.NativeFieldInfoPtr_NetherSpawnCoffinPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe float GizmoHeight
    {
      get
      {
        float gizmoHeight;
        IL2CPP.il2cpp_field_static_get_value(NetherSpawnPositionAuthoring.NativeFieldInfoPtr_GizmoHeight, (void*) &gizmoHeight);
        return gizmoHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetherSpawnPositionAuthoring.NativeFieldInfoPtr_GizmoHeight, (void*) &value);
      }
    }
  }
}
