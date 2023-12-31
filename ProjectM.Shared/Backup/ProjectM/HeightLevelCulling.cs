// Decompiled with JetBrains decompiler
// Type: ProjectM.HeightLevelCulling
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class HeightLevelCulling : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHeightBasedCulling_Public_Static_Void_EntityManager_Entity_Int32_Boolean_Boolean_Boolean_0;

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 722785, RefRangeEnd = 722792, XrefRangeStart = 722769, XrefRangeEnd = 722785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddHeightBasedCulling(
      EntityManager entityManager,
      Entity entity,
      int heightOffset,
      bool requireRenderMesh = true,
      bool occlusionCulling = true,
      bool alwaysCullAbove = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &heightOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &requireRenderMesh;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &occlusionCulling;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &alwaysCullAbove;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HeightLevelCulling.NativeMethodInfoPtr_AddHeightBasedCulling_Public_Static_Void_EntityManager_Entity_Int32_Boolean_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HeightLevelCulling()
    {
      Il2CppClassPointerStore<HeightLevelCulling>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HeightLevelCulling));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeightLevelCulling>.NativeClassPtr);
      HeightLevelCulling.NativeMethodInfoPtr_AddHeightBasedCulling_Public_Static_Void_EntityManager_Entity_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightLevelCulling>.NativeClassPtr, 100663844);
    }

    public HeightLevelCulling(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
