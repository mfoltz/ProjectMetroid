// Decompiled with JetBrains decompiler
// Type: ProjectM.Destroy_BuffModificationsSystem_Server
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
  public class Destroy_BuffModificationsSystem_Server : SystemBase
  {
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
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402869, XrefRangeEnd = 1403026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Destroy_BuffModificationsSystem_Server()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1403026, XrefRangeEnd = 1403156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403178, RefRangeEnd = 1403179, XrefRangeStart = 1403156, XrefRangeEnd = 1403178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403204, RefRangeEnd = 1403205, XrefRangeStart = 1403179, XrefRangeEnd = 1403204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403230, RefRangeEnd = 1403231, XrefRangeStart = 1403205, XrefRangeEnd = 1403230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403256, RefRangeEnd = 1403257, XrefRangeStart = 1403231, XrefRangeEnd = 1403256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob3_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403282, RefRangeEnd = 1403283, XrefRangeStart = 1403257, XrefRangeEnd = 1403282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob4_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403308, RefRangeEnd = 1403309, XrefRangeStart = 1403283, XrefRangeEnd = 1403308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob5_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob5_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403334, RefRangeEnd = 1403335, XrefRangeStart = 1403309, XrefRangeEnd = 1403334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob6_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob6_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403360, RefRangeEnd = 1403361, XrefRangeStart = 1403335, XrefRangeEnd = 1403360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob7_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob7_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403365, RefRangeEnd = 1403366, XrefRangeStart = 1403361, XrefRangeEnd = 1403365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403370, RefRangeEnd = 1403371, XrefRangeStart = 1403366, XrefRangeEnd = 1403370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403375, RefRangeEnd = 1403376, XrefRangeStart = 1403371, XrefRangeEnd = 1403375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403380, RefRangeEnd = 1403381, XrefRangeStart = 1403376, XrefRangeEnd = 1403380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403385, RefRangeEnd = 1403386, XrefRangeStart = 1403381, XrefRangeEnd = 1403385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403390, RefRangeEnd = 1403391, XrefRangeStart = 1403386, XrefRangeEnd = 1403390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403395, RefRangeEnd = 1403396, XrefRangeStart = 1403391, XrefRangeEnd = 1403395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_6()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_6, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1403400, RefRangeEnd = 1403401, XrefRangeStart = 1403396, XrefRangeEnd = 1403400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_7()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_7, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Destroy_BuffModificationsSystem_Server()
    {
      Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (Destroy_BuffModificationsSystem_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr);
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob2_entityQuery");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob2_profilerMarker");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob3_entityQuery");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob3_profilerMarker");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob4_entityQuery");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob4_profilerMarker");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob5_entityQuery");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob5_profilerMarker");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob6_entityQuery");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob6_profilerMarker");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob7_entityQuery");
      Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob7_profilerMarker");
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667711);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667712);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667713);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667714);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667715);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667716);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667717);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667718);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob5_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667719);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob6_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667720);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob7_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667721);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667722);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667723);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667724);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667725);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667726);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667727);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667728);
      Destroy_BuffModificationsSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_7 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, 100667729);
    }

    public Destroy_BuffModificationsSystem_Server(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob3_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob3_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob4_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob4_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob5_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob5_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob5_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob6_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob6_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob6_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob7_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob7_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_BuffModificationsSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob7_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/<>c__DisplayClass0_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass0_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAbilityBar_Shared;
      private static readonly System.IntPtr NativeFieldInfoPtr_getIntModifications;
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
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_BuffModificationFlagData_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_Buff_byref_LimitAbilityPriorityModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_byref_SetDynamicCollisionHardnessModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_Buff_byref_FollowBuffOwnerModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_byref_DisableAggroBuffModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_Buff_byref_PreventDisableBuffModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuffModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuffModifications_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public ComponentDataFromEntity<AbilityBar_Shared> getAbilityBar_Shared;
      [FieldOffset(40)]
      public BufferFromEntity<IntModificationBuffer> getIntModifications;
      [FieldOffset(80)]
      public ComponentDataFromEntity<DynamicCollision> getDynamicCollision;
      [FieldOffset(112)]
      public BufferFromEntity<FloatModificationBuffer> getFloatModifications;
      [FieldOffset(152)]
      public ComponentDataFromEntity<Follower> getFollower;
      [FieldOffset(184)]
      public BufferFromEntity<EntityModificationBuffer> getEntityModifications;
      [FieldOffset(224)]
      public ComponentDataFromEntity<Aggroable> getAggroable;
      [FieldOffset(256)]
      public BufferFromEntity<BoolModificationBuffer> getBoolModifications;
      [FieldOffset(296)]
      public ComponentDataFromEntity<AggroConsumer> getAggroConsumer;
      [FieldOffset(328)]
      public ComponentDataFromEntity<CanPreventDisableWhenNoPlayersInRange> getCanPreventDisableWhenNoPlayersInRange;
      [FieldOffset(360)]
      public ComponentDataFromEntity<CanFly> getCanFly;
      [FieldOffset(392)]
      public ComponentDataFromEntity<AggroModifiers> getAggroModifiers;
      [FieldOffset(424)]
      public ComponentDataFromEntity<AlertModifiers> getAlertModifiers;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        ref BuffModificationFlagData buffModificationData,
        [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref buffModificationData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_BuffModificationFlagData_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        [In] ref Buff buff,
        [In] ref LimitAbilityPriorityModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_Buff_byref_LimitAbilityPriorityModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        [In] ref Buff buff,
        [In] ref SetDynamicCollisionHardnessBuff hardnessBuff,
        [In] ref SetDynamicCollisionHardnessModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref hardnessBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_byref_SetDynamicCollisionHardnessModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        Entity entity,
        [In] ref Buff buff,
        [In] ref FollowBuffOwnerModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_Buff_byref_FollowBuffOwnerModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        Entity entity,
        [In] ref Buff buff,
        [In] ref DisableAggroBuff disableAggroBuff,
        [In] ref DisableAggroBuffModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref disableAggroBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_byref_DisableAggroBuffModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__5(
        Entity entity,
        [In] ref Buff buff,
        [In] ref PreventDisableBuffModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_Buff_byref_PreventDisableBuffModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__6(
        Entity entity,
        [In] ref Buff buff,
        [In] ref AdjustFlyHeightBuffModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuffModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__7(
        Entity entity,
        [In] ref Buff buff,
        [In] ref ModifyAggroRangesBuffModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuffModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (entityManager));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getAbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getAbilityBar_Shared));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getIntModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getIntModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getDynamicCollision));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getFloatModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getFloatModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getFollower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getFollower));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getEntityModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getEntityModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getAggroable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getAggroable));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getBoolModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getBoolModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getAggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getAggroConsumer));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getCanPreventDisableWhenNoPlayersInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getCanPreventDisableWhenNoPlayersInRange));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getCanFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getCanFly));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getAggroModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getAggroModifiers));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeFieldInfoPtr_getAlertModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, nameof (getAlertModifiers));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, 100667730);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_BuffModificationFlagData_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, 100667731);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_Buff_byref_LimitAbilityPriorityModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, 100667732);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_byref_SetDynamicCollisionHardnessModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, 100667733);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_Buff_byref_FollowBuffOwnerModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, 100667734);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_byref_DisableAggroBuffModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, 100667735);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_Buff_byref_PreventDisableBuffModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, 100667736);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuffModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, 100667737);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuffModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, 100667738);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BuffModificationFlagData_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401853, XrefRangeEnd = 1401865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref BuffModificationFlagData buffModificationData,
        [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref buffModificationData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BuffModificationFlagData_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 927059, RefRangeEnd = 927105, XrefRangeStart = 927059, XrefRangeEnd = 927105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(47)]
      [CachedScanResults(RefRangeStart = 927105, RefRangeEnd = 927152, XrefRangeStart = 927105, XrefRangeEnd = 927152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401865, XrefRangeEnd = 1401867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1401875, RefRangeEnd = 1401876, XrefRangeStart = 1401867, XrefRangeEnd = 1401875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1401878, RefRangeEnd = 1401879, XrefRangeStart = 1401876, XrefRangeEnd = 1401878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Destroy_BuffModificationsSystem_Server componentSystem,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401879, XrefRangeEnd = 1401883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401883, XrefRangeEnd = 1401889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BuffModificationFlagData_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667739);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667740);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667741);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667742);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667743);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667744);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667745);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667746);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffModificationData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<BuffModificationFlagData> forParameter_buffModificationData;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1401770, RefRangeEnd = 1401771, XrefRangeStart = 1401764, XrefRangeEnd = 1401770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Destroy_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1401777, RefRangeEnd = 1401778, XrefRangeStart = 1401771, XrefRangeEnd = 1401777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffModificationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffModificationData));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667747);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667748);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffModificationData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<BuffModificationFlagData>.Runtime runtime_buffModificationData;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;

          static Runtimes()
          {
            Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffModificationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffModificationData));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00000A99$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000A99$PostfixBurstDelegate");
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667749);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667750);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667751);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667752);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00000A99$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401778, XrefRangeEnd = 1401792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401792, XrefRangeEnd = 1401810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401810, XrefRangeEnd = 1401825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1401852, RefRangeEnd = 1401853, XrefRangeStart = 1401825, XrefRangeEnd = 1401852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000A99$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667753);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667754);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667755);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667756);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667758);
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
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getAbilityBar_Shared;
      private static readonly System.IntPtr NativeFieldInfoPtr_getIntModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_LimitAbilityPriorityModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<AbilityBar_Shared> getAbilityBar_Shared;
      [FieldOffset(32)]
      public BufferFromEntity<IntModificationBuffer> getIntModifications;
      [FieldOffset(72)]
      public Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(144)]
      public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401980, XrefRangeEnd = 1401992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref LimitAbilityPriorityModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_LimitAbilityPriorityModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1401992, RefRangeEnd = 1401993, XrefRangeStart = 1401992, XrefRangeEnd = 1401992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1401993, RefRangeEnd = 1401994, XrefRangeStart = 1401993, XrefRangeEnd = 1401993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401994, XrefRangeEnd = 1401996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402005, RefRangeEnd = 1402006, XrefRangeStart = 1401996, XrefRangeEnd = 1402005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402008, RefRangeEnd = 1402009, XrefRangeStart = 1402006, XrefRangeEnd = 1402008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Destroy_BuffModificationsSystem_Server componentSystem,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402009, XrefRangeEnd = 1402013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402013, XrefRangeEnd = 1402019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_getAbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (getAbilityBar_Shared));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_getIntModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (getIntModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_LimitAbilityPriorityModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667759);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667760);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667761);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667762);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667763);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667764);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667765);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667766);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifications;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<LimitAbilityPriorityModifications> forParameter_modifications;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1401896, RefRangeEnd = 1401897, XrefRangeStart = 1401889, XrefRangeEnd = 1401896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Destroy_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1401904, RefRangeEnd = 1401905, XrefRangeStart = 1401897, XrefRangeEnd = 1401904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifications));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100667767);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100667768);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifications;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<LimitAbilityPriorityModifications>.Runtime runtime_modifications;

          static Runtimes()
          {
            Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifications));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_00000AA2$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000AA2$PostfixBurstDelegate");
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667769);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667770);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667771);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667772);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_00000AA2$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401905, XrefRangeEnd = 1401919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401919, XrefRangeEnd = 1401937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401937, XrefRangeEnd = 1401952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1401979, RefRangeEnd = 1401980, XrefRangeStart = 1401952, XrefRangeEnd = 1401979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000AA2$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667773);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667774);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667775);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667776);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667778);
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
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getDynamicCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFloatModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_byref_SetDynamicCollisionHardnessModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<DynamicCollision> getDynamicCollision;
      [FieldOffset(32)]
      public BufferFromEntity<FloatModificationBuffer> getFloatModifications;
      [FieldOffset(72)]
      public Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(176)]
      public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402116, XrefRangeEnd = 1402132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref SetDynamicCollisionHardnessBuff hardnessBuff,
        [In] ref SetDynamicCollisionHardnessModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref hardnessBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_byref_SetDynamicCollisionHardnessModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402132, RefRangeEnd = 1402133, XrefRangeStart = 1402132, XrefRangeEnd = 1402132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402133, RefRangeEnd = 1402134, XrefRangeStart = 1402133, XrefRangeEnd = 1402133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402134, XrefRangeEnd = 1402136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402148, RefRangeEnd = 1402149, XrefRangeStart = 1402136, XrefRangeEnd = 1402148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402151, RefRangeEnd = 1402152, XrefRangeStart = 1402149, XrefRangeEnd = 1402151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Destroy_BuffModificationsSystem_Server componentSystem,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402152, XrefRangeEnd = 1402156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402156, XrefRangeEnd = 1402162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob2()
      {
        Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_getDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (getDynamicCollision));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_getFloatModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (getFloatModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetDynamicCollisionHardnessBuff_byref_SetDynamicCollisionHardnessModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667779);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667780);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667781);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667782);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667783);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667784);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667785);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100667786);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hardnessBuff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifications;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<SetDynamicCollisionHardnessBuff> forParameter_hardnessBuff;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<SetDynamicCollisionHardnessModifications> forParameter_modifications;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402029, RefRangeEnd = 1402030, XrefRangeStart = 1402019, XrefRangeEnd = 1402029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Destroy_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402040, RefRangeEnd = 1402041, XrefRangeStart = 1402030, XrefRangeEnd = 1402040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hardnessBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hardnessBuff));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifications));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100667787);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100667788);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hardnessBuff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifications;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<SetDynamicCollisionHardnessBuff>.Runtime runtime_hardnessBuff;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<SetDynamicCollisionHardnessModifications>.Runtime runtime_modifications;

          static Runtimes()
          {
            Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hardnessBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hardnessBuff));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifications));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.RunWithoutJobSystem_00000AAB$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000AAB$PostfixBurstDelegate");
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667789);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667790);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667791);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667792);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.RunWithoutJobSystem_00000AAB$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402041, XrefRangeEnd = 1402055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402055, XrefRangeEnd = 1402073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402073, XrefRangeEnd = 1402088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402115, RefRangeEnd = 1402116, XrefRangeStart = 1402088, XrefRangeEnd = 1402115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000AAB$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667793);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667794);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667795);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667796);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667798);
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
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob3")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob3
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getFollower;
      private static readonly System.IntPtr NativeFieldInfoPtr_getEntityModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_getIntModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_FollowBuffOwnerModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Follower> getFollower;
      [FieldOffset(32)]
      public BufferFromEntity<EntityModificationBuffer> getEntityModifications;
      [FieldOffset(72)]
      public BufferFromEntity<IntModificationBuffer> getIntModifications;
      [FieldOffset(112)]
      public Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(184)]
      public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402253, XrefRangeEnd = 1402270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref FollowBuffOwnerModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_FollowBuffOwnerModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402270, RefRangeEnd = 1402271, XrefRangeStart = 1402270, XrefRangeEnd = 1402270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402271, RefRangeEnd = 1402272, XrefRangeStart = 1402271, XrefRangeEnd = 1402271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402272, XrefRangeEnd = 1402274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402283, RefRangeEnd = 1402284, XrefRangeStart = 1402274, XrefRangeEnd = 1402283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402286, RefRangeEnd = 1402287, XrefRangeStart = 1402284, XrefRangeEnd = 1402286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Destroy_BuffModificationsSystem_Server componentSystem,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402287, XrefRangeEnd = 1402291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402291, XrefRangeEnd = 1402297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob3()
      {
        Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_getFollower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (getFollower));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_getEntityModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (getEntityModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_getIntModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (getIntModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (_runtimes));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_FollowBuffOwnerModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667799);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667800);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667801);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667802);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667803);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667804);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667805);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100667806);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifications;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FollowBuffOwnerModifications> forParameter_modifications;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402169, RefRangeEnd = 1402170, XrefRangeStart = 1402162, XrefRangeEnd = 1402169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Destroy_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402177, RefRangeEnd = 1402178, XrefRangeStart = 1402170, XrefRangeEnd = 1402177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifications));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100667807);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100667808);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifications;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<FollowBuffOwnerModifications>.Runtime runtime_modifications;

          static Runtimes()
          {
            Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifications));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob3/ProjectM.RunWithoutJobSystem_00000AB4$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_00000AB4$PostfixBurstDelegate");
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667809);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667810);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667811);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667812);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob3/ProjectM.RunWithoutJobSystem_00000AB4$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402178, XrefRangeEnd = 1402192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402192, XrefRangeEnd = 1402210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402210, XrefRangeEnd = 1402225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402252, RefRangeEnd = 1402253, XrefRangeStart = 1402225, XrefRangeEnd = 1402252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_00000AB4$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667813);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667814);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667815);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667816);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667818);
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
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob4")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob4
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getAggroable;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBoolModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAggroConsumer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_byref_DisableAggroBuffModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Aggroable> getAggroable;
      [FieldOffset(32)]
      public BufferFromEntity<BoolModificationBuffer> getBoolModifications;
      [FieldOffset(72)]
      public ComponentDataFromEntity<AggroConsumer> getAggroConsumer;
      [FieldOffset(104)]
      public Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(208)]
      public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402394, XrefRangeEnd = 1402418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref DisableAggroBuff disableAggroBuff,
        [In] ref DisableAggroBuffModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref disableAggroBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_byref_DisableAggroBuffModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402418, RefRangeEnd = 1402419, XrefRangeStart = 1402418, XrefRangeEnd = 1402418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402419, RefRangeEnd = 1402420, XrefRangeStart = 1402419, XrefRangeEnd = 1402419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402420, XrefRangeEnd = 1402422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402434, RefRangeEnd = 1402435, XrefRangeStart = 1402422, XrefRangeEnd = 1402434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402437, RefRangeEnd = 1402438, XrefRangeStart = 1402435, XrefRangeEnd = 1402437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Destroy_BuffModificationsSystem_Server componentSystem,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402438, XrefRangeEnd = 1402442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402442, XrefRangeEnd = 1402448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob4()
      {
        Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_getAggroable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (getAggroable));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_getBoolModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (getBoolModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_getAggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (getAggroConsumer));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (_runtimes));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_DisableAggroBuff_byref_DisableAggroBuffModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667819);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667820);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667821);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667822);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667823);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667824);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667825);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667826);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_disableAggroBuff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifications;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<DisableAggroBuff> forParameter_disableAggroBuff;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<DisableAggroBuffModifications> forParameter_modifications;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402307, RefRangeEnd = 1402308, XrefRangeStart = 1402297, XrefRangeEnd = 1402307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Destroy_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402318, RefRangeEnd = 1402319, XrefRangeStart = 1402308, XrefRangeEnd = 1402318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_disableAggroBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_disableAggroBuff));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifications));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100667827);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100667828);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_disableAggroBuff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifications;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<DisableAggroBuff>.Runtime runtime_disableAggroBuff;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<DisableAggroBuffModifications>.Runtime runtime_modifications;

          static Runtimes()
          {
            Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_disableAggroBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_disableAggroBuff));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifications));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob4/ProjectM.RunWithoutJobSystem_00000ABD$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_00000ABD$PostfixBurstDelegate");
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667829);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667830);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667831);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667832);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob4/ProjectM.RunWithoutJobSystem_00000ABD$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402319, XrefRangeEnd = 1402333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402333, XrefRangeEnd = 1402351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402351, XrefRangeEnd = 1402366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402393, RefRangeEnd = 1402394, XrefRangeStart = 1402366, XrefRangeEnd = 1402393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_00000ABD$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667833);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667834);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667835);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667836);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667838);
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
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob5")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob5
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getCanPreventDisableWhenNoPlayersInRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBoolModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_PreventDisableBuffModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<CanPreventDisableWhenNoPlayersInRange> getCanPreventDisableWhenNoPlayersInRange;
      [FieldOffset(32)]
      public BufferFromEntity<BoolModificationBuffer> getBoolModifications;
      [FieldOffset(72)]
      public Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(144)]
      public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402539, XrefRangeEnd = 1402558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref PreventDisableBuffModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_PreventDisableBuffModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402558, RefRangeEnd = 1402559, XrefRangeStart = 1402558, XrefRangeEnd = 1402558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402559, RefRangeEnd = 1402560, XrefRangeStart = 1402559, XrefRangeEnd = 1402559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402560, XrefRangeEnd = 1402562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402571, RefRangeEnd = 1402572, XrefRangeStart = 1402562, XrefRangeEnd = 1402571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402574, RefRangeEnd = 1402575, XrefRangeStart = 1402572, XrefRangeEnd = 1402574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Destroy_BuffModificationsSystem_Server componentSystem,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402575, XrefRangeEnd = 1402579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402579, XrefRangeEnd = 1402585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob5()
      {
        Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob5");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_getCanPreventDisableWhenNoPlayersInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (getCanPreventDisableWhenNoPlayersInRange));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_getBoolModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (getBoolModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (_runtimes));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_PreventDisableBuffModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667839);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667840);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667841);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667842);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667843);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667844);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667845);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, 100667846);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifications;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<PreventDisableBuffModifications> forParameter_modifications;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402455, RefRangeEnd = 1402456, XrefRangeStart = 1402448, XrefRangeEnd = 1402455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Destroy_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402463, RefRangeEnd = 1402464, XrefRangeStart = 1402456, XrefRangeEnd = 1402463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifications));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, 100667847);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, 100667848);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifications;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<PreventDisableBuffModifications>.Runtime runtime_modifications;

          static Runtimes()
          {
            Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifications));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob5/ProjectM.RunWithoutJobSystem_00000AC6$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, "RunWithoutJobSystem_00000AC6$PostfixBurstDelegate");
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667849);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667850);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667851);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667852);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob5/ProjectM.RunWithoutJobSystem_00000AC6$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402464, XrefRangeEnd = 1402478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402478, XrefRangeEnd = 1402496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402496, XrefRangeEnd = 1402511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402538, RefRangeEnd = 1402539, XrefRangeStart = 1402511, XrefRangeEnd = 1402538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5>.NativeClassPtr, "RunWithoutJobSystem_00000AC6$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667853);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667854);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667855);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667856);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667858);
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
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob6")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob6
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getCanFly;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFloatModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuffModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<CanFly> getCanFly;
      [FieldOffset(32)]
      public BufferFromEntity<FloatModificationBuffer> getFloatModifications;
      [FieldOffset(72)]
      public Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(144)]
      public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402676, XrefRangeEnd = 1402688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref AdjustFlyHeightBuffModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuffModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402688, RefRangeEnd = 1402689, XrefRangeStart = 1402688, XrefRangeEnd = 1402688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402689, RefRangeEnd = 1402690, XrefRangeStart = 1402689, XrefRangeEnd = 1402689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402690, XrefRangeEnd = 1402692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402701, RefRangeEnd = 1402702, XrefRangeStart = 1402692, XrefRangeEnd = 1402701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402704, RefRangeEnd = 1402705, XrefRangeStart = 1402702, XrefRangeEnd = 1402704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Destroy_BuffModificationsSystem_Server componentSystem,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402705, XrefRangeEnd = 1402709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402709, XrefRangeEnd = 1402715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob6()
      {
        Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob6");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_getCanFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (getCanFly));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_getFloatModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (getFloatModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (_runtimes));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_AdjustFlyHeightBuffModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667859);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667860);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667861);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667862);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667863);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667864);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667865);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, 100667866);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifications;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<AdjustFlyHeightBuffModifications> forParameter_modifications;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402592, RefRangeEnd = 1402593, XrefRangeStart = 1402585, XrefRangeEnd = 1402592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Destroy_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402600, RefRangeEnd = 1402601, XrefRangeStart = 1402593, XrefRangeEnd = 1402600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifications));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, 100667867);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, 100667868);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifications;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<AdjustFlyHeightBuffModifications>.Runtime runtime_modifications;

          static Runtimes()
          {
            Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifications));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob6/ProjectM.RunWithoutJobSystem_00000ACF$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, "RunWithoutJobSystem_00000ACF$PostfixBurstDelegate");
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667869);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667870);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667871);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667872);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob6/ProjectM.RunWithoutJobSystem_00000ACF$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402601, XrefRangeEnd = 1402615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402615, XrefRangeEnd = 1402633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402633, XrefRangeEnd = 1402648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402675, RefRangeEnd = 1402676, XrefRangeStart = 1402648, XrefRangeEnd = 1402675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6>.NativeClassPtr, "RunWithoutJobSystem_00000ACF$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667873);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667874);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667875);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667876);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667878);
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
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob7")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob7
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getAggroModifiers;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFloatModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAlertModifiers;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuffModifications_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<AggroModifiers> getAggroModifiers;
      [FieldOffset(32)]
      public BufferFromEntity<FloatModificationBuffer> getFloatModifications;
      [FieldOffset(72)]
      public ComponentDataFromEntity<AlertModifiers> getAlertModifiers;
      [FieldOffset(104)]
      public Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(176)]
      public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402806, XrefRangeEnd = 1402842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref ModifyAggroRangesBuffModifications modifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuffModifications_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402842, RefRangeEnd = 1402843, XrefRangeStart = 1402842, XrefRangeEnd = 1402842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402843, RefRangeEnd = 1402844, XrefRangeStart = 1402843, XrefRangeEnd = 1402843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402844, XrefRangeEnd = 1402846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402855, RefRangeEnd = 1402856, XrefRangeStart = 1402846, XrefRangeEnd = 1402855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1402858, RefRangeEnd = 1402859, XrefRangeStart = 1402856, XrefRangeEnd = 1402858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Destroy_BuffModificationsSystem_Server componentSystem,
        ref Destroy_BuffModificationsSystem_Server.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402859, XrefRangeEnd = 1402863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402863, XrefRangeEnd = 1402869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob7()
      {
        Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob7");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_getAggroModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (getAggroModifiers));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_getFloatModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (getFloatModifications));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_getAlertModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (getAlertModifiers));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (_runtimes));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_ModifyAggroRangesBuffModifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667879);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667880);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667881);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667882);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667883);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667884);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667885);
        Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, 100667886);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifications;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<ModifyAggroRangesBuffModifications> forParameter_modifications;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402722, RefRangeEnd = 1402723, XrefRangeStart = 1402715, XrefRangeEnd = 1402722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Destroy_BuffModificationsSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402730, RefRangeEnd = 1402731, XrefRangeStart = 1402723, XrefRangeEnd = 1402730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifications));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_BuffModificationsSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, 100667887);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, 100667888);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifications;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<ModifyAggroRangesBuffModifications>.Runtime runtime_modifications;

          static Runtimes()
          {
            Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifications));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob7/ProjectM.RunWithoutJobSystem_00000AD8$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, "RunWithoutJobSystem_00000AD8$PostfixBurstDelegate");
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667889);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667890);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667891);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667892);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Destroy_BuffModificationsSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob7/ProjectM.RunWithoutJobSystem_00000AD8$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402731, XrefRangeEnd = 1402745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402745, XrefRangeEnd = 1402763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402763, XrefRangeEnd = 1402778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1402805, RefRangeEnd = 1402806, XrefRangeStart = 1402778, XrefRangeEnd = 1402805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7>.NativeClassPtr, "RunWithoutJobSystem_00000AD8$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667893);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667894);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667895);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667896);
          Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667898);
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
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_BuffModificationsSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
