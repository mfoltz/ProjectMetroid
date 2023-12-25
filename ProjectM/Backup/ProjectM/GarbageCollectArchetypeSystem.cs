// Decompiled with JetBrains decompiler
// Type: ProjectM.GarbageCollectArchetypeSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Diagnostics;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class GarbageCollectArchetypeSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__Stopwatch;
    private static readonly IntPtr NativeFieldInfoPtr__LastIndexCollected;
    private static readonly IntPtr NativeFieldInfoPtr__LastChunkDefragmentationIndex;
    private static readonly IntPtr NativeFieldInfoPtr__SceneTagMask;
    private static readonly IntPtr NativeFieldInfoPtr__PrefabMask;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_PerformChunkDefragmentationAll_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044198, XrefRangeEnd = 1044227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GarbageCollectArchetypeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044227, XrefRangeEnd = 1044233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GarbageCollectArchetypeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1044241, RefRangeEnd = 1044242, XrefRangeStart = 1044233, XrefRangeEnd = 1044241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PerformChunkDefragmentationAll(bool logResult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &logResult;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GarbageCollectArchetypeSystem.NativeMethodInfoPtr_PerformChunkDefragmentationAll_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GarbageCollectArchetypeSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GarbageCollectArchetypeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GarbageCollectArchetypeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GarbageCollectArchetypeSystem()
    {
      Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GarbageCollectArchetypeSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr);
      GarbageCollectArchetypeSystem.NativeFieldInfoPtr__Stopwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr, nameof (_Stopwatch));
      GarbageCollectArchetypeSystem.NativeFieldInfoPtr__LastIndexCollected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr, nameof (_LastIndexCollected));
      GarbageCollectArchetypeSystem.NativeFieldInfoPtr__LastChunkDefragmentationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr, nameof (_LastChunkDefragmentationIndex));
      GarbageCollectArchetypeSystem.NativeFieldInfoPtr__SceneTagMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr, nameof (_SceneTagMask));
      GarbageCollectArchetypeSystem.NativeFieldInfoPtr__PrefabMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr, nameof (_PrefabMask));
      GarbageCollectArchetypeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr, 100681827);
      GarbageCollectArchetypeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr, 100681828);
      GarbageCollectArchetypeSystem.NativeMethodInfoPtr_PerformChunkDefragmentationAll_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr, 100681829);
      GarbageCollectArchetypeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr, 100681830);
      GarbageCollectArchetypeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarbageCollectArchetypeSystem>.NativeClassPtr, 100681831);
    }

    public GarbageCollectArchetypeSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Stopwatch _Stopwatch
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GarbageCollectArchetypeSystem.NativeFieldInfoPtr__Stopwatch));
        return pointer == IntPtr.Zero ? (Stopwatch) null : new Stopwatch(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GarbageCollectArchetypeSystem.NativeFieldInfoPtr__Stopwatch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _LastIndexCollected
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GarbageCollectArchetypeSystem.NativeFieldInfoPtr__LastIndexCollected));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GarbageCollectArchetypeSystem.NativeFieldInfoPtr__LastIndexCollected)) = value;
      }
    }

    public unsafe int _LastChunkDefragmentationIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GarbageCollectArchetypeSystem.NativeFieldInfoPtr__LastChunkDefragmentationIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GarbageCollectArchetypeSystem.NativeFieldInfoPtr__LastChunkDefragmentationIndex)) = value;
      }
    }

    public unsafe EntityQueryMask _SceneTagMask
    {
      get
      {
        return *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GarbageCollectArchetypeSystem.NativeFieldInfoPtr__SceneTagMask));
      }
      [param: In] set
      {
        *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GarbageCollectArchetypeSystem.NativeFieldInfoPtr__SceneTagMask)) = value;
      }
    }

    public unsafe EntityQueryMask _PrefabMask
    {
      get
      {
        return *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GarbageCollectArchetypeSystem.NativeFieldInfoPtr__PrefabMask));
      }
      [param: In] set
      {
        *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GarbageCollectArchetypeSystem.NativeFieldInfoPtr__PrefabMask)) = value;
      }
    }
  }
}
