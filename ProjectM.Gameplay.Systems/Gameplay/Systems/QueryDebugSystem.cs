// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.QueryDebugSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class QueryDebugSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InitializationFrames;
    private static readonly System.IntPtr NativeFieldInfoPtr_FramesToLeakInARowBeforeLog;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastCheckedQueryCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__FramesLeakedInARow;
    private static readonly System.IntPtr NativeFieldInfoPtr__QueriesLeakedInARow;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_WorldFrame_24;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1457600, XrefRangeEnd = 1457627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), QueryDebugSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe QueryDebugSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryDebugSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1457627, XrefRangeEnd = 1457635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), QueryDebugSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static QueryDebugSystem()
    {
      Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (QueryDebugSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr);
      QueryDebugSystem.NativeFieldInfoPtr_InitializationFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr, nameof (InitializationFrames));
      QueryDebugSystem.NativeFieldInfoPtr_FramesToLeakInARowBeforeLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr, nameof (FramesToLeakInARowBeforeLog));
      QueryDebugSystem.NativeFieldInfoPtr__LastCheckedQueryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr, nameof (_LastCheckedQueryCount));
      QueryDebugSystem.NativeFieldInfoPtr__FramesLeakedInARow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr, nameof (_FramesLeakedInARow));
      QueryDebugSystem.NativeFieldInfoPtr__QueriesLeakedInARow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr, nameof (_QueriesLeakedInARow));
      QueryDebugSystem.NativeFieldInfoPtr__SingletonEntityQuery_WorldFrame_24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_WorldFrame_24));
      QueryDebugSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr, 100673375);
      QueryDebugSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr, 100673376);
      QueryDebugSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDebugSystem>.NativeClassPtr, 100673377);
    }

    public QueryDebugSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int InitializationFrames
    {
      get
      {
        int initializationFrames;
        IL2CPP.il2cpp_field_static_get_value(QueryDebugSystem.NativeFieldInfoPtr_InitializationFrames, (void*) &initializationFrames);
        return initializationFrames;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(QueryDebugSystem.NativeFieldInfoPtr_InitializationFrames, (void*) &value);
      }
    }

    public static unsafe int FramesToLeakInARowBeforeLog
    {
      get
      {
        int leakInArowBeforeLog;
        IL2CPP.il2cpp_field_static_get_value(QueryDebugSystem.NativeFieldInfoPtr_FramesToLeakInARowBeforeLog, (void*) &leakInArowBeforeLog);
        return leakInArowBeforeLog;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(QueryDebugSystem.NativeFieldInfoPtr_FramesToLeakInARowBeforeLog, (void*) &value);
      }
    }

    public unsafe Nullable_Unboxed<int> _LastCheckedQueryCount
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryDebugSystem.NativeFieldInfoPtr__LastCheckedQueryCount));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryDebugSystem.NativeFieldInfoPtr__LastCheckedQueryCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _FramesLeakedInARow
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryDebugSystem.NativeFieldInfoPtr__FramesLeakedInARow));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryDebugSystem.NativeFieldInfoPtr__FramesLeakedInARow)) = value;
      }
    }

    public unsafe int _QueriesLeakedInARow
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryDebugSystem.NativeFieldInfoPtr__QueriesLeakedInARow));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryDebugSystem.NativeFieldInfoPtr__QueriesLeakedInARow)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_WorldFrame_24
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryDebugSystem.NativeFieldInfoPtr__SingletonEntityQuery_WorldFrame_24));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryDebugSystem.NativeFieldInfoPtr__SingletonEntityQuery_WorldFrame_24)) = value;
      }
    }
  }
}
