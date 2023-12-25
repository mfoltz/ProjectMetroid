// Decompiled with JetBrains decompiler
// Type: ProjectM.Apply_BuffModificationsSystem_Server
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class Apply_BuffModificationsSystem_Server : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob5_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob5_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob6_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob6_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob7_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob7_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob5_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob6_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob7_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_6;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_7;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400740, XrefRangeEnd = 1400746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400746, XrefRangeEnd = 1400914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Apply_BuffModificationsSystem_Server()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400914, XrefRangeEnd = 1401044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401066, RefRangeEnd = 1401067, XrefRangeStart = 1401044, XrefRangeEnd = 1401066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401095, RefRangeEnd = 1401096, XrefRangeStart = 1401067, XrefRangeEnd = 1401095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401124, RefRangeEnd = 1401125, XrefRangeStart = 1401096, XrefRangeEnd = 1401124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401156, RefRangeEnd = 1401157, XrefRangeStart = 1401125, XrefRangeEnd = 1401156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob3_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401185, RefRangeEnd = 1401186, XrefRangeStart = 1401157, XrefRangeEnd = 1401185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob4_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401214, RefRangeEnd = 1401215, XrefRangeStart = 1401186, XrefRangeEnd = 1401214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob5_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob5_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401243, RefRangeEnd = 1401244, XrefRangeStart = 1401215, XrefRangeEnd = 1401243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob6_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob6_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401272, RefRangeEnd = 1401273, XrefRangeStart = 1401244, XrefRangeEnd = 1401272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob7_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob7_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401277, RefRangeEnd = 1401278, XrefRangeStart = 1401273, XrefRangeEnd = 1401277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401282, RefRangeEnd = 1401283, XrefRangeStart = 1401278, XrefRangeEnd = 1401282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401287, RefRangeEnd = 1401288, XrefRangeStart = 1401283, XrefRangeEnd = 1401287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401292, RefRangeEnd = 1401293, XrefRangeStart = 1401288, XrefRangeEnd = 1401292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401297, RefRangeEnd = 1401298, XrefRangeStart = 1401293, XrefRangeEnd = 1401297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401302, RefRangeEnd = 1401303, XrefRangeStart = 1401298, XrefRangeEnd = 1401302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401307, RefRangeEnd = 1401308, XrefRangeStart = 1401303, XrefRangeEnd = 1401307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_6()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_6, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1401312, RefRangeEnd = 1401313, XrefRangeStart = 1401308, XrefRangeEnd = 1401312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_7()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_7, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Apply_BuffModificationsSystem_Server()
    {
      Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (Apply_BuffModificationsSystem_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr);
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, nameof (_ModificationSystem));
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob2_entityQuery");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob2_profilerMarker");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob3_entityQuery");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob3_profilerMarker");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob4_entityQuery");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob4_profilerMarker");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob5_entityQuery");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob5_profilerMarker");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob6_entityQuery");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob6_profilerMarker");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob7_entityQuery");
      Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob7_profilerMarker");
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667466);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667467);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667468);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667469);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667470);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667471);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667472);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667473);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667474);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob5_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667475);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob6_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667476);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob7_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667477);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667478);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667479);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667480);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667481);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667482);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667483);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667484);
      Apply_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_7 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, 100667485);
    }

    public Apply_BuffModificationsSystem_Server(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob3_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob3_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob4_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob4_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob5_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob5_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob6_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob6_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob7_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob7_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Apply_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/<>c__DisplayClass2_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass2_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAbilityBar_Shared;
      private static readonly System.IntPtr NativeFieldInfoPtr_getIntModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getDynamicCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFloatModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFollower;
      private static readonly System.IntPtr NativeFieldInfoPtr_getEntityModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAggroable;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBoolModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAggroConsumer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getCanPreventDisableWhenNoPlayersInRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_getCanFly;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAggroModifiers;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAlertModifiers;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_BuffModificationFlagData_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_LimitAbilityPriorityBuff_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_Buff_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuff_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public ModificationStructure modificationStruct;
      [FieldOffset(40)]
      public ComponentDataFromEntity<AbilityBar_Shared> getAbilityBar_Shared;
      [FieldOffset(72)]
      public BufferFromEntity<IntModificationBuffer> getIntModifications;
      [FieldOffset(112)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(128)]
      public ComponentDataFromEntity<DynamicCollision> getDynamicCollision;
      [FieldOffset(160)]
      public BufferFromEntity<FloatModificationBuffer> getFloatModifications;
      [FieldOffset(200)]
      public ComponentDataFromEntity<Follower> getFollower;
      [FieldOffset(232)]
      public BufferFromEntity<EntityModificationBuffer> getEntityModifications;
      [FieldOffset(272)]
      public ComponentDataFromEntity<Aggroable> getAggroable;
      [FieldOffset(304)]
      public BufferFromEntity<BoolModificationBuffer> getBoolModifications;
      [FieldOffset(344)]
      public ComponentDataFromEntity<AggroConsumer> getAggroConsumer;
      [FieldOffset(376)]
      public ComponentDataFromEntity<CanPreventDisableWhenNoPlayersInRange> getCanPreventDisableWhenNoPlayersInRange;
      [FieldOffset(408)]
      public ComponentDataFromEntity<CanFly> getCanFly;
      [FieldOffset(440)]
      public ComponentDataFromEntity<AggroModifiers> getAggroModifiers;
      [FieldOffset(472)]
      public ComponentDataFromEntity<AlertModifiers> getAlertModifiers;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref BuffModificationFlagData buffModificationData,
        [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffModificationData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_BuffModificationFlagData_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        [In] ref LimitAbilityPriorityBuff limitAbilityPriorityBuff,
        [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref limitAbilityPriorityBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_LimitAbilityPriorityBuff_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        [In] ref Buff buff,
        [In] ref SetDynamicCollisionHardnessBuff hardnessBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref hardnessBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(Entity entity, [In] ref Buff buff, [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_Buff_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        Entity entity,
        [In] ref Buff buff,
        [In] ref DisableAggroBuff disableAggroBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref disableAggroBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__5(Entity entity, [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__6(
        Entity entity,
        [In] ref Buff buff,
        [In] ref AdjustFlyHeightBuff adjust)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref adjust;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__7(
        Entity entity,
        [In] ref Buff buff,
        [In] ref ModifyAggroRangesBuff modifyAggroFactorsBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifyAggroFactorsBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (entityManager));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (modificationStruct));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getAbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getAbilityBar_Shared));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getIntModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getIntModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (commandBuffer));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getDynamicCollision));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getFloatModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getFloatModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getFollower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getFollower));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getEntityModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getEntityModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getAggroable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getAggroable));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getBoolModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getBoolModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getAggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getAggroConsumer));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getCanPreventDisableWhenNoPlayersInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getCanPreventDisableWhenNoPlayersInRange));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getCanFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getCanFly));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getAggroModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getAggroModifiers));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeFieldInfoPtr_getAlertModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, nameof (getAlertModifiers));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, 100667486);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_BuffModificationFlagData_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, 100667487);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_LimitAbilityPriorityBuff_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, 100667488);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, 100667489);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_Buff_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, 100667490);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, 100667491);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, 100667492);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, 100667493);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, 100667494);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_BuffModificationFlagData_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public ModificationStructure modificationStruct;
      [FieldOffset(40)]
      public Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(112)]
      public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399722, XrefRangeEnd = 1399734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref BuffModificationFlagData buffModificationData,
        [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffModificationData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_BuffModificationFlagData_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 1379308, RefRangeEnd = 1379313, XrefRangeStart = 1379308, XrefRangeEnd = 1379313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 1379313, RefRangeEnd = 1379318, XrefRangeStart = 1379313, XrefRangeEnd = 1379318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399734, XrefRangeEnd = 1399736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1399745, RefRangeEnd = 1399746, XrefRangeStart = 1399736, XrefRangeEnd = 1399745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1399748, RefRangeEnd = 1399749, XrefRangeStart = 1399746, XrefRangeEnd = 1399748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Apply_BuffModificationsSystem_Server componentSystem,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399749, XrefRangeEnd = 1399753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399753, XrefRangeEnd = 1399759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (modificationStruct));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_BuffModificationFlagData_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667495);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667496);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667497);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667498);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667499);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667500);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667501);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667502);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffModificationData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<BuffModificationFlagData> forParameter_buffModificationData;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1399638, RefRangeEnd = 1399639, XrefRangeStart = 1399631, XrefRangeEnd = 1399638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Apply_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1399646, RefRangeEnd = 1399647, XrefRangeStart = 1399639, XrefRangeEnd = 1399646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffModificationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffModificationData));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667503);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667504);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffModificationData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<BuffModificationFlagData>.Runtime runtime_buffModificationData;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;

          static Runtimes()
          {
            Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffModificationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffModificationData));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00000A1D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000A1D$PostfixBurstDelegate");
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667505);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667506);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667507);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667508);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00000A1D$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399647, XrefRangeEnd = 1399661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399661, XrefRangeEnd = 1399679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399679, XrefRangeEnd = 1399694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1399721, RefRangeEnd = 1399722, XrefRangeStart = 1399694, XrefRangeEnd = 1399721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000A1D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667509);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667510);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667511);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667512);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667514);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getAbilityBar_Shared;
      private static readonly System.IntPtr NativeFieldInfoPtr_getIntModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LimitAbilityPriorityBuff_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<AbilityBar_Shared> getAbilityBar_Shared;
      [FieldOffset(32)]
      public BufferFromEntity<IntModificationBuffer> getIntModifications;
      [FieldOffset(72)]
      public ModificationStructure modificationStruct;
      [FieldOffset(104)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(120)]
      public Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(192)]
      public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399850, XrefRangeEnd = 1399868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref LimitAbilityPriorityBuff limitAbilityPriorityBuff,
        [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref limitAbilityPriorityBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LimitAbilityPriorityBuff_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1399868, RefRangeEnd = 1399869, XrefRangeStart = 1399868, XrefRangeEnd = 1399868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1399869, RefRangeEnd = 1399870, XrefRangeStart = 1399869, XrefRangeEnd = 1399869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399870, XrefRangeEnd = 1399872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1399881, RefRangeEnd = 1399882, XrefRangeStart = 1399872, XrefRangeEnd = 1399881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1399884, RefRangeEnd = 1399885, XrefRangeStart = 1399882, XrefRangeEnd = 1399884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Apply_BuffModificationsSystem_Server componentSystem,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399885, XrefRangeEnd = 1399889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399889, XrefRangeEnd = 1399895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_getAbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (getAbilityBar_Shared));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_getIntModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (getIntModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (modificationStruct));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (commandBuffer));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LimitAbilityPriorityBuff_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667515);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667516);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667517);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667518);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667519);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667520);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667521);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667522);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_limitAbilityPriorityBuff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<LimitAbilityPriorityBuff> forParameter_limitAbilityPriorityBuff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1399766, RefRangeEnd = 1399767, XrefRangeStart = 1399759, XrefRangeEnd = 1399766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Apply_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1399774, RefRangeEnd = 1399775, XrefRangeStart = 1399767, XrefRangeEnd = 1399774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_limitAbilityPriorityBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_limitAbilityPriorityBuff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100667523);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100667524);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_limitAbilityPriorityBuff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<LimitAbilityPriorityBuff>.Runtime runtime_limitAbilityPriorityBuff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;

          static Runtimes()
          {
            Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_limitAbilityPriorityBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_limitAbilityPriorityBuff));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_00000A26$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000A26$PostfixBurstDelegate");
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667525);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667526);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667527);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667528);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_00000A26$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399775, XrefRangeEnd = 1399789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399789, XrefRangeEnd = 1399807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399807, XrefRangeEnd = 1399822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1399849, RefRangeEnd = 1399850, XrefRangeStart = 1399822, XrefRangeEnd = 1399849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000A26$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667529);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667530);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667531);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667532);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667534);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getDynamicCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFloatModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<DynamicCollision> getDynamicCollision;
      [FieldOffset(32)]
      public BufferFromEntity<FloatModificationBuffer> getFloatModifications;
      [FieldOffset(72)]
      public ModificationStructure modificationStruct;
      [FieldOffset(104)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(120)]
      public Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(192)]
      public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399986, XrefRangeEnd = 1400006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref SetDynamicCollisionHardnessBuff hardnessBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref hardnessBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400006, RefRangeEnd = 1400007, XrefRangeStart = 1400006, XrefRangeEnd = 1400006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400007, RefRangeEnd = 1400008, XrefRangeStart = 1400007, XrefRangeEnd = 1400007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400008, XrefRangeEnd = 1400010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400019, RefRangeEnd = 1400020, XrefRangeStart = 1400010, XrefRangeEnd = 1400019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400022, RefRangeEnd = 1400023, XrefRangeStart = 1400020, XrefRangeEnd = 1400022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Apply_BuffModificationsSystem_Server componentSystem,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400023, XrefRangeEnd = 1400027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400027, XrefRangeEnd = 1400033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob2()
      {
        Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_getDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (getDynamicCollision));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_getFloatModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (getFloatModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (modificationStruct));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (commandBuffer));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667535);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667536);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667537);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667538);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667539);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667540);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667541);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667542);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hardnessBuff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<SetDynamicCollisionHardnessBuff> forParameter_hardnessBuff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1399902, RefRangeEnd = 1399903, XrefRangeStart = 1399895, XrefRangeEnd = 1399902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Apply_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1399910, RefRangeEnd = 1399911, XrefRangeStart = 1399903, XrefRangeEnd = 1399910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hardnessBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hardnessBuff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100667543);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100667544);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hardnessBuff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<SetDynamicCollisionHardnessBuff>.Runtime runtime_hardnessBuff;

          static Runtimes()
          {
            Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hardnessBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hardnessBuff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.RunWithoutJobSystem_00000A2F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000A2F$PostfixBurstDelegate");
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667545);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667546);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667547);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667548);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.RunWithoutJobSystem_00000A2F$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399911, XrefRangeEnd = 1399925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399925, XrefRangeEnd = 1399943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399943, XrefRangeEnd = 1399958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1399985, RefRangeEnd = 1399986, XrefRangeStart = 1399958, XrefRangeEnd = 1399985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000A2F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667549);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667550);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667551);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667552);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667554);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob3")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob3
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getFollower;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_getEntityModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_getIntModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Follower> getFollower;
      [FieldOffset(32)]
      public ModificationStructure modificationStruct;
      [FieldOffset(64)]
      public BufferFromEntity<EntityModificationBuffer> getEntityModifications;
      [FieldOffset(104)]
      public BufferFromEntity<IntModificationBuffer> getIntModifications;
      [FieldOffset(144)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(160)]
      public Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(232)]
      public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400124, XrefRangeEnd = 1400147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400147, RefRangeEnd = 1400148, XrefRangeStart = 1400147, XrefRangeEnd = 1400147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400148, RefRangeEnd = 1400149, XrefRangeStart = 1400148, XrefRangeEnd = 1400148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400149, XrefRangeEnd = 1400151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400160, RefRangeEnd = 1400161, XrefRangeStart = 1400151, XrefRangeEnd = 1400160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400163, RefRangeEnd = 1400164, XrefRangeStart = 1400161, XrefRangeEnd = 1400163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Apply_BuffModificationsSystem_Server componentSystem,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400164, XrefRangeEnd = 1400168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400168, XrefRangeEnd = 1400174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob3()
      {
        Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_getFollower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (getFollower));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (modificationStruct));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_getEntityModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (getEntityModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_getIntModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (getIntModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (commandBuffer));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (_runtimes));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667555);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667556);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667557);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667558);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667559);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667560);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667561);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667562);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400040, RefRangeEnd = 1400041, XrefRangeStart = 1400033, XrefRangeEnd = 1400040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Apply_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400048, RefRangeEnd = 1400049, XrefRangeStart = 1400041, XrefRangeEnd = 1400048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100667563);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100667564);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob3/ProjectM.RunWithoutJobSystem_00000A38$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_00000A38$PostfixBurstDelegate");
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667565);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667566);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667567);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667568);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob3/ProjectM.RunWithoutJobSystem_00000A38$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400049, XrefRangeEnd = 1400063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400063, XrefRangeEnd = 1400081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400081, XrefRangeEnd = 1400096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400123, RefRangeEnd = 1400124, XrefRangeStart = 1400096, XrefRangeEnd = 1400123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_00000A38$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667569);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667570);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667571);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667572);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667574);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob4")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob4
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getAggroable;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBoolModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAggroConsumer;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Aggroable> getAggroable;
      [FieldOffset(32)]
      public ModificationStructure modificationStruct;
      [FieldOffset(64)]
      public BufferFromEntity<BoolModificationBuffer> getBoolModifications;
      [FieldOffset(104)]
      public ComponentDataFromEntity<AggroConsumer> getAggroConsumer;
      [FieldOffset(136)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(152)]
      public Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(224)]
      public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400265, XrefRangeEnd = 1400296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref DisableAggroBuff disableAggroBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref disableAggroBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400296, RefRangeEnd = 1400297, XrefRangeStart = 1400296, XrefRangeEnd = 1400296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400297, RefRangeEnd = 1400298, XrefRangeStart = 1400297, XrefRangeEnd = 1400297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400298, XrefRangeEnd = 1400300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400309, RefRangeEnd = 1400310, XrefRangeStart = 1400300, XrefRangeEnd = 1400309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400312, RefRangeEnd = 1400313, XrefRangeStart = 1400310, XrefRangeEnd = 1400312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Apply_BuffModificationsSystem_Server componentSystem,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400313, XrefRangeEnd = 1400317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400317, XrefRangeEnd = 1400323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob4()
      {
        Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_getAggroable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (getAggroable));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (modificationStruct));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_getBoolModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (getBoolModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_getAggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (getAggroConsumer));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (commandBuffer));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (_runtimes));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667575);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667576);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667577);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667578);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667579);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667580);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667581);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667582);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_disableAggroBuff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<DisableAggroBuff> forParameter_disableAggroBuff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400181, RefRangeEnd = 1400182, XrefRangeStart = 1400174, XrefRangeEnd = 1400181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Apply_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400189, RefRangeEnd = 1400190, XrefRangeStart = 1400182, XrefRangeEnd = 1400189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_disableAggroBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_disableAggroBuff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100667583);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100667584);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_disableAggroBuff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<DisableAggroBuff>.Runtime runtime_disableAggroBuff;

          static Runtimes()
          {
            Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_disableAggroBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_disableAggroBuff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob4/ProjectM.RunWithoutJobSystem_00000A41$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_00000A41$PostfixBurstDelegate");
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667585);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667586);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667587);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667588);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob4/ProjectM.RunWithoutJobSystem_00000A41$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400190, XrefRangeEnd = 1400204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400204, XrefRangeEnd = 1400222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400222, XrefRangeEnd = 1400237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400264, RefRangeEnd = 1400265, XrefRangeStart = 1400237, XrefRangeEnd = 1400264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_00000A41$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667589);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667590);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667591);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667592);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667594);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob5")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob5
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getCanPreventDisableWhenNoPlayersInRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBoolModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<CanPreventDisableWhenNoPlayersInRange> getCanPreventDisableWhenNoPlayersInRange;
      [FieldOffset(32)]
      public ModificationStructure modificationStruct;
      [FieldOffset(64)]
      public BufferFromEntity<BoolModificationBuffer> getBoolModifications;
      [FieldOffset(104)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(120)]
      public Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(160)]
      public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400408, XrefRangeEnd = 1400426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400426, RefRangeEnd = 1400427, XrefRangeStart = 1400426, XrefRangeEnd = 1400426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400427, RefRangeEnd = 1400428, XrefRangeStart = 1400427, XrefRangeEnd = 1400427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400428, XrefRangeEnd = 1400430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400436, RefRangeEnd = 1400437, XrefRangeStart = 1400430, XrefRangeEnd = 1400436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400439, RefRangeEnd = 1400440, XrefRangeStart = 1400437, XrefRangeEnd = 1400439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Apply_BuffModificationsSystem_Server componentSystem,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400440, XrefRangeEnd = 1400444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400444, XrefRangeEnd = 1400450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob5()
      {
        Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob5");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_getCanPreventDisableWhenNoPlayersInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (getCanPreventDisableWhenNoPlayersInRange));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (modificationStruct));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_getBoolModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (getBoolModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (commandBuffer));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (_runtimes));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667595);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667596);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667597);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667598);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667599);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667600);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667601);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667602);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400327, RefRangeEnd = 1400328, XrefRangeStart = 1400323, XrefRangeEnd = 1400327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Apply_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400332, RefRangeEnd = 1400333, XrefRangeStart = 1400328, XrefRangeEnd = 1400332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, 100667603);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, 100667604);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;

          static Runtimes()
          {
            Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob5/ProjectM.RunWithoutJobSystem_00000A4A$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, "RunWithoutJobSystem_00000A4A$PostfixBurstDelegate");
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667605);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667606);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667607);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667608);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob5/ProjectM.RunWithoutJobSystem_00000A4A$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400333, XrefRangeEnd = 1400347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400347, XrefRangeEnd = 1400365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400365, XrefRangeEnd = 1400380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400407, RefRangeEnd = 1400408, XrefRangeStart = 1400380, XrefRangeEnd = 1400407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, "RunWithoutJobSystem_00000A4A$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667609);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667610);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667611);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667612);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667614);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob6")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob6
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getCanFly;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFloatModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<CanFly> getCanFly;
      [FieldOffset(32)]
      public ModificationStructure modificationStruct;
      [FieldOffset(64)]
      public BufferFromEntity<FloatModificationBuffer> getFloatModifications;
      [FieldOffset(104)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(120)]
      public Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(192)]
      public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400541, XrefRangeEnd = 1400559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref AdjustFlyHeightBuff adjust)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref adjust;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400559, RefRangeEnd = 1400560, XrefRangeStart = 1400559, XrefRangeEnd = 1400559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400560, RefRangeEnd = 1400561, XrefRangeStart = 1400560, XrefRangeEnd = 1400560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400561, XrefRangeEnd = 1400563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400572, RefRangeEnd = 1400573, XrefRangeStart = 1400563, XrefRangeEnd = 1400572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400575, RefRangeEnd = 1400576, XrefRangeStart = 1400573, XrefRangeEnd = 1400575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Apply_BuffModificationsSystem_Server componentSystem,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400576, XrefRangeEnd = 1400580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400580, XrefRangeEnd = 1400586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob6()
      {
        Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob6");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_getCanFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (getCanFly));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (modificationStruct));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_getFloatModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (getFloatModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (commandBuffer));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (_runtimes));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667615);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667616);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667617);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667618);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667619);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667620);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667621);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667622);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_adjust;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<AdjustFlyHeightBuff> forParameter_adjust;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400457, RefRangeEnd = 1400458, XrefRangeStart = 1400450, XrefRangeEnd = 1400457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Apply_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400465, RefRangeEnd = 1400466, XrefRangeStart = 1400458, XrefRangeEnd = 1400465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_adjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_adjust));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, 100667623);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, 100667624);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_adjust;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<AdjustFlyHeightBuff>.Runtime runtime_adjust;

          static Runtimes()
          {
            Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_adjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_adjust));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob6/ProjectM.RunWithoutJobSystem_00000A53$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, "RunWithoutJobSystem_00000A53$PostfixBurstDelegate");
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667625);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667626);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667627);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667628);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob6/ProjectM.RunWithoutJobSystem_00000A53$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400466, XrefRangeEnd = 1400480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400480, XrefRangeEnd = 1400498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400498, XrefRangeEnd = 1400513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400540, RefRangeEnd = 1400541, XrefRangeStart = 1400513, XrefRangeEnd = 1400540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, "RunWithoutJobSystem_00000A53$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667629);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667630);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667631);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667632);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667634);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob7")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob7
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getAggroModifiers;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAlertModifiers;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFloatModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<AggroModifiers> getAggroModifiers;
      [FieldOffset(32)]
      public ComponentDataFromEntity<AlertModifiers> getAlertModifiers;
      [FieldOffset(64)]
      public ModificationStructure modificationStruct;
      [FieldOffset(96)]
      public BufferFromEntity<FloatModificationBuffer> getFloatModifications;
      [FieldOffset(136)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(152)]
      public Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(224)]
      public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400677, XrefRangeEnd = 1400713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref ModifyAggroRangesBuff modifyAggroFactorsBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifyAggroFactorsBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400713, RefRangeEnd = 1400714, XrefRangeStart = 1400713, XrefRangeEnd = 1400713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400714, RefRangeEnd = 1400715, XrefRangeStart = 1400714, XrefRangeEnd = 1400714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400715, XrefRangeEnd = 1400717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400726, RefRangeEnd = 1400727, XrefRangeStart = 1400717, XrefRangeEnd = 1400726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1400729, RefRangeEnd = 1400730, XrefRangeStart = 1400727, XrefRangeEnd = 1400729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Apply_BuffModificationsSystem_Server componentSystem,
        ref Apply_BuffModificationsSystem_Server.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400730, XrefRangeEnd = 1400734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400734, XrefRangeEnd = 1400740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob7()
      {
        Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob7");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_getAggroModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (getAggroModifiers));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_getAlertModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (getAlertModifiers));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (modificationStruct));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_getFloatModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (getFloatModifications));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (commandBuffer));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (_runtimes));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667635);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667636);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667637);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667638);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667639);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667640);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667641);
        Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667642);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifyAggroFactorsBuff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<ModifyAggroRangesBuff> forParameter_modifyAggroFactorsBuff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400593, RefRangeEnd = 1400594, XrefRangeStart = 1400586, XrefRangeEnd = 1400593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Apply_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400601, RefRangeEnd = 1400602, XrefRangeStart = 1400594, XrefRangeEnd = 1400601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifyAggroFactorsBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifyAggroFactorsBuff));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Apply_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, 100667643);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, 100667644);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifyAggroFactorsBuff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<ModifyAggroRangesBuff>.Runtime runtime_modifyAggroFactorsBuff;

          static Runtimes()
          {
            Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifyAggroFactorsBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifyAggroFactorsBuff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob7/ProjectM.RunWithoutJobSystem_00000A5C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, "RunWithoutJobSystem_00000A5C$PostfixBurstDelegate");
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667645);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667646);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667647);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667648);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Apply_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob7/ProjectM.RunWithoutJobSystem_00000A5C$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400602, XrefRangeEnd = 1400616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400616, XrefRangeEnd = 1400634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400634, XrefRangeEnd = 1400649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1400676, RefRangeEnd = 1400677, XrefRangeStart = 1400649, XrefRangeEnd = 1400676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, "RunWithoutJobSystem_00000A5C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667649);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667650);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667651);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667652);
          Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667654);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Apply_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
