// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.CastOptionsUtility
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  public static class CastOptionsUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_FindStateEntity_Internal_Static_Entity_Entity_Entity_BufferFromEntity_1_CastOptionStateBuffer_ComponentDataFromEntity_1_BehaviourTreeState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindStateEntity_Internal_Static_Entity_EntityManager_Entity_Entity_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342738, XrefRangeEnd = 1342756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity FindStateEntity(
      Entity subject,
      Entity castOptionsPrefabEntity,
      BufferFromEntity<CastOptionStateBuffer> getCastOptionStateBuffer,
      ComponentDataFromEntity<BehaviourTreeState> getBehaviourTreeState)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &subject;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &castOptionsPrefabEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastOptionStateBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getBehaviourTreeState;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionsUtility.NativeMethodInfoPtr_FindStateEntity_Internal_Static_Entity_Entity_Entity_BufferFromEntity_1_CastOptionStateBuffer_ComponentDataFromEntity_1_BehaviourTreeState_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342756, XrefRangeEnd = 1342774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity FindStateEntity(
      EntityManager entityManager,
      Entity subject,
      Entity castOptionsPrefabEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &subject;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &castOptionsPrefabEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionsUtility.NativeMethodInfoPtr_FindStateEntity_Internal_Static_Entity_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastOptionsUtility()
    {
      Il2CppClassPointerStore<CastOptionsUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (CastOptionsUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionsUtility>.NativeClassPtr);
      CastOptionsUtility.NativeMethodInfoPtr_FindStateEntity_Internal_Static_Entity_Entity_Entity_BufferFromEntity_1_CastOptionStateBuffer_ComponentDataFromEntity_1_BehaviourTreeState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsUtility>.NativeClassPtr, 100665269);
      CastOptionsUtility.NativeMethodInfoPtr_FindStateEntity_Internal_Static_Entity_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsUtility>.NativeClassPtr, 100665270);
    }

    public CastOptionsUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
