// Decompiled with JetBrains decompiler
// Type: ProjectM.SceneSystemExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;
using Unity.Scenes;

#nullable disable
namespace ProjectM
{
  public static class SceneSystemExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSceneMetadataLoaded_Public_Static_Boolean_SceneSystem_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSceneMetadataLoaded_Public_Static_Boolean_ComponentDataFromEntity_1_SceneReference_BufferFromEntity_1_ResolvedSectionEntity_Entity_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735749, XrefRangeEnd = 735764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsSceneMetadataLoaded(
      this SceneSystem sceneSystem,
      Entity metadataEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sceneSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &metadataEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SceneSystemExtensions.NativeMethodInfoPtr_IsSceneMetadataLoaded_Public_Static_Boolean_SceneSystem_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 735776, RefRangeEnd = 735777, XrefRangeStart = 735764, XrefRangeEnd = 735776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsSceneMetadataLoaded(
      ComponentDataFromEntity<SceneReference> getSceneReference,
      BufferFromEntity<ResolvedSectionEntity> getResolvedSections,
      Entity metadataEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &getSceneReference;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getResolvedSections;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &metadataEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SceneSystemExtensions.NativeMethodInfoPtr_IsSceneMetadataLoaded_Public_Static_Boolean_ComponentDataFromEntity_1_SceneReference_BufferFromEntity_1_ResolvedSectionEntity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SceneSystemExtensions()
    {
      Il2CppClassPointerStore<SceneSystemExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SceneSystemExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneSystemExtensions>.NativeClassPtr);
      SceneSystemExtensions.NativeMethodInfoPtr_IsSceneMetadataLoaded_Public_Static_Boolean_SceneSystem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneSystemExtensions>.NativeClassPtr, 100664962);
      SceneSystemExtensions.NativeMethodInfoPtr_IsSceneMetadataLoaded_Public_Static_Boolean_ComponentDataFromEntity_1_SceneReference_BufferFromEntity_1_ResolvedSectionEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneSystemExtensions>.NativeClassPtr, 100664963);
    }

    public SceneSystemExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
