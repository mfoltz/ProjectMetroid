﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkEditorColliderParent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public class ChunkEditorColliderParent : MonoBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkEditorColliderParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkEditorColliderParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkEditorColliderParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkEditorColliderParent()
    {
      Il2CppClassPointerStore<ChunkEditorColliderParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Terrain", nameof (ChunkEditorColliderParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkEditorColliderParent>.NativeClassPtr);
      ChunkEditorColliderParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEditorColliderParent>.NativeClassPtr, 100689242);
    }

    public ChunkEditorColliderParent(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
