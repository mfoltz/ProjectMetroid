// Decompiled with JetBrains decompiler
// Type: ProjectM.KillUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class KillUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Kill_Public_Static_Entity_EntityCommandBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Kill_Public_Static_Entity_ParallelWriter_Int32_Entity_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 763636, RefRangeEnd = 763639, XrefRangeStart = 763635, XrefRangeEnd = 763636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity Kill(EntityCommandBuffer commandBuffer, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KillUtility.NativeMethodInfoPtr_Kill_Public_Static_Entity_EntityCommandBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763639, XrefRangeEnd = 763640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity Kill(
      EntityCommandBuffer.ParallelWriter commandBuffer,
      int jobIndex,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &jobIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KillUtility.NativeMethodInfoPtr_Kill_Public_Static_Entity_ParallelWriter_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    static KillUtility()
    {
      Il2CppClassPointerStore<KillUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (KillUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KillUtility>.NativeClassPtr);
      KillUtility.NativeMethodInfoPtr_Kill_Public_Static_Entity_EntityCommandBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillUtility>.NativeClassPtr, 100667463);
      KillUtility.NativeMethodInfoPtr_Kill_Public_Static_Entity_ParallelWriter_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillUtility>.NativeClassPtr, 100667464);
    }

    public KillUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
