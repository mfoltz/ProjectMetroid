// Decompiled with JetBrains decompiler
// Type: ProjectM.DrawTileGridSystem`2
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag> : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NewPreviewQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__CleanupPreviewQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawGridSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightLevelOffset;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDrawQuery_Protected_EntityQuery_Il2CppStructArray_1_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Final_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Final_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDrawGridJob_Protected_DrawTileGridJob_1_TShowTileGrid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroyDrawGridSystem_Protected_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 733498, RefRangeEnd = 733499, XrefRangeStart = 733491, XrefRangeEnd = 733498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntityQuery GetDrawQuery(
      [Optional] Il2CppStructArray<ComponentType> additionalComponents)
    {
      if (additionalComponents == null)
        additionalComponents = new Il2CppStructArray<ComponentType>(0L);
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) additionalComponents);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_GetDrawQuery_Protected_EntityQuery_Il2CppStructArray_1_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733499, XrefRangeEnd = 733627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733627, XrefRangeEnd = 733668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733668, XrefRangeEnd = 733708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 733708, RefRangeEnd = 733717, XrefRangeStart = 733708, XrefRangeEnd = 733708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DrawTileGridJob<TShowTileGrid> CreateDrawGridJob()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_CreateDrawGridJob_Protected_DrawTileGridJob_1_TShowTileGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DrawTileGridJob<TShowTileGrid>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnCreateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnDestroyDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnDestroyDrawGridSystem_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnUpdateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(22)]
    [CachedScanResults(RefRangeStart = 178542, RefRangeEnd = 178564, XrefRangeStart = 178542, XrefRangeEnd = 178564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DrawTileGridSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 262491, RefRangeEnd = 262548, XrefRangeStart = 262491, XrefRangeEnd = 262548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public EntityQuery GetDrawQuery(params ComponentType[] additionalComponents)
    {
      return ((DrawTileGridSystem<,>) this).GetDrawQuery(new Il2CppStructArray<ComponentType>(additionalComponents));
    }

    static DrawTileGridSystem()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "DrawTileGridSystem`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TShowTileGrid>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGridIsActiveTag>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr);
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr__NewPreviewQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, nameof (_NewPreviewQuery));
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr__CleanupPreviewQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, nameof (_CleanupPreviewQuery));
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr_DrawGridSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, nameof (DrawGridSettings));
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr_HeightLevelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, nameof (HeightLevelOffset));
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_GetDrawQuery_Protected_EntityQuery_Il2CppStructArray_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, 100664822);
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, 100664823);
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, 100664824);
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, 100664825);
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, 100664826);
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_CreateDrawGridJob_Protected_DrawTileGridJob_1_TShowTileGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, 100664827);
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, 100664828);
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnDestroyDrawGridSystem_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, 100664829);
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, 100664830);
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, 100664831);
      DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>>.NativeClassPtr, 100664832);
    }

    public DrawTileGridSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _NewPreviewQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr__NewPreviewQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr__NewPreviewQuery)) = value;
      }
    }

    public unsafe EntityQuery _CleanupPreviewQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr__CleanupPreviewQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr__CleanupPreviewQuery)) = value;
      }
    }

    public unsafe DrawGrid DrawGridSettings
    {
      get
      {
        return *(DrawGrid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr_DrawGridSettings));
      }
      [param: In] set
      {
        *(DrawGrid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr_DrawGridSettings)) = value;
      }
    }

    public unsafe int HeightLevelOffset
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr_HeightLevelOffset));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawTileGridSystem<TShowTileGrid, TGridIsActiveTag>.NativeFieldInfoPtr_HeightLevelOffset)) = value;
      }
    }
  }
}
