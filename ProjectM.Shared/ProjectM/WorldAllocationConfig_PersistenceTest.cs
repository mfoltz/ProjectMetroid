﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldAllocationConfig_PersistenceTest
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM
{
  public class WorldAllocationConfig_PersistenceTest : WorldTypeAllocationConfig
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetSceneSystemConfiguration_Private_Static_SceneSystemConfiguration_Boolean_Boolean_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722319, XrefRangeEnd = 722325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldAllocationConfig_PersistenceTest()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldAllocationConfig_PersistenceTest>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldAllocationConfig_PersistenceTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Unity.Scenes.SceneSystemConfiguration GetSceneSystemConfiguration(
      bool supportSynchronousStreaming,
      bool supportAsynchronousStreaming)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &supportSynchronousStreaming;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &supportAsynchronousStreaming;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldAllocationConfig_PersistenceTest.NativeMethodInfoPtr_GetSceneSystemConfiguration_Private_Static_SceneSystemConfiguration_Boolean_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Unity.Scenes.SceneSystemConfiguration*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WorldAllocationConfig_PersistenceTest()
    {
      Il2CppClassPointerStore<WorldAllocationConfig_PersistenceTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WorldAllocationConfig_PersistenceTest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldAllocationConfig_PersistenceTest>.NativeClassPtr);
      WorldAllocationConfig_PersistenceTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldAllocationConfig_PersistenceTest>.NativeClassPtr, 100663790);
      WorldAllocationConfig_PersistenceTest.NativeMethodInfoPtr_GetSceneSystemConfiguration_Private_Static_SceneSystemConfiguration_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldAllocationConfig_PersistenceTest>.NativeClassPtr, 100663791);
    }

    public WorldAllocationConfig_PersistenceTest(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}