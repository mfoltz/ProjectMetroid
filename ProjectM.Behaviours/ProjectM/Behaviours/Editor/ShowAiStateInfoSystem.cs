// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.Editor.ShowAiStateInfoSystem
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;
using UnityEngine;

#nullable disable
namespace ProjectM.Behaviours.Editor
{
  public class ShowAiStateInfoSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_COLOR;
    private static readonly System.IntPtr NativeFieldInfoPtr__PickerButtonPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__Instances;
    private static readonly System.IntPtr NativeFieldInfoPtr__CanvasGO;
    private static readonly System.IntPtr NativeFieldInfoPtr__Rects;
    private static readonly System.IntPtr NativeFieldInfoPtr__Elements;
    private static readonly System.IntPtr NativeFieldInfoPtr__TextGenerator;
    private static readonly System.IntPtr NativeFieldInfoPtr__TextGenerationSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__UserActivityGridSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindAggroPrefabs_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindAggroPrefabs_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindAiStatePrefabs_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindAiStatePrefabs_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindCrowdednessPrefabs_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindCrowdednessPrefabs_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ShowAi_10;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateResources_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyResources_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldDrawAnything_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindAggroPrefabs_Private_Boolean_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindAiStatePrefabs_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindCrowdednessPrefabs_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FormatFloat_Private_String_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FormatDouble_Private_String_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateButtonsFromElements_Private_Void_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFindAggroPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFindAiStatePrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFindCrowdednessPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346672, XrefRangeEnd = 1346714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowAiStateInfoSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346714, XrefRangeEnd = 1346718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowAiStateInfoSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346718, XrefRangeEnd = 1346739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateResources()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_CreateResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1346750, RefRangeEnd = 1346751, XrefRangeStart = 1346739, XrefRangeEnd = 1346750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyResources()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_DestroyResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346751, XrefRangeEnd = 1346801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowAiStateInfoSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346801, XrefRangeEnd = 1346810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldDrawAnything()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_ShouldDrawAnything_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1346876, RefRangeEnd = 1346877, XrefRangeStart = 1346810, XrefRangeEnd = 1346876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool FindAggroPrefabs(double serverTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_FindAggroPrefabs_Private_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1346916, RefRangeEnd = 1346917, XrefRangeStart = 1346877, XrefRangeEnd = 1346916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FindAiStatePrefabs()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_FindAiStatePrefabs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1346971, RefRangeEnd = 1346972, XrefRangeStart = 1346917, XrefRangeEnd = 1346971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FindCrowdednessPrefabs()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_FindCrowdednessPrefabs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1346975, RefRangeEnd = 1346979, XrefRangeStart = 1346972, XrefRangeEnd = 1346975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string FormatFloat(float v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_FormatFloat_Private_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1346982, RefRangeEnd = 1346983, XrefRangeStart = 1346979, XrefRangeEnd = 1346982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string FormatDouble(double v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_FormatDouble_Private_String_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1347038, RefRangeEnd = 1347039, XrefRangeStart = 1346983, XrefRangeEnd = 1347038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateButtonsFromElements(Nullable_Unboxed<float> forceWidth = default (Nullable_Unboxed<float>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &forceWidth;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_CreateButtonsFromElements_Private_Void_Nullable_Unboxed_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShowAiStateInfoSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1347039, XrefRangeEnd = 1347099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowAiStateInfoSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1347127, RefRangeEnd = 1347128, XrefRangeStart = 1347099, XrefRangeEnd = 1347127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFindAggroPrefabs_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr___GetEntityQuery_ForFindAggroPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1347153, RefRangeEnd = 1347154, XrefRangeStart = 1347128, XrefRangeEnd = 1347153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFindAiStatePrefabs_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr___GetEntityQuery_ForFindAiStatePrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1347179, RefRangeEnd = 1347180, XrefRangeStart = 1347154, XrefRangeEnd = 1347179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFindCrowdednessPrefabs_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr___GetEntityQuery_ForFindCrowdednessPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1347184, RefRangeEnd = 1347185, XrefRangeStart = 1347180, XrefRangeEnd = 1347184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1347189, RefRangeEnd = 1347190, XrefRangeStart = 1347185, XrefRangeEnd = 1347189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1347194, RefRangeEnd = 1347195, XrefRangeStart = 1347190, XrefRangeEnd = 1347194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShowAiStateInfoSystem()
    {
      Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours.Editor", nameof (ShowAiStateInfoSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr);
      ShowAiStateInfoSystem.NativeFieldInfoPtr_LABEL_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (LABEL_COLOR));
      ShowAiStateInfoSystem.NativeFieldInfoPtr__PickerButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (_PickerButtonPrefab));
      ShowAiStateInfoSystem.NativeFieldInfoPtr__Instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (_Instances));
      ShowAiStateInfoSystem.NativeFieldInfoPtr__CanvasGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (_CanvasGO));
      ShowAiStateInfoSystem.NativeFieldInfoPtr__Rects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (_Rects));
      ShowAiStateInfoSystem.NativeFieldInfoPtr__Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (_Elements));
      ShowAiStateInfoSystem.NativeFieldInfoPtr__TextGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (_TextGenerator));
      ShowAiStateInfoSystem.NativeFieldInfoPtr__TextGenerationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (_TextGenerationSettings));
      ShowAiStateInfoSystem.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (_ServerTimeAccessor));
      ShowAiStateInfoSystem.NativeFieldInfoPtr__UserActivityGridSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (_UserActivityGridSystem));
      ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAggroPrefabs_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>FindAggroPrefabs_LambdaJob0_entityQuery");
      ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAggroPrefabs_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>FindAggroPrefabs_LambdaJob0_profilerMarker");
      ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAiStatePrefabs_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>FindAiStatePrefabs_LambdaJob0_entityQuery");
      ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAiStatePrefabs_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>FindAiStatePrefabs_LambdaJob0_profilerMarker");
      ShowAiStateInfoSystem.NativeFieldInfoPtr___FindCrowdednessPrefabs_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>FindCrowdednessPrefabs_LambdaJob0_entityQuery");
      ShowAiStateInfoSystem.NativeFieldInfoPtr___FindCrowdednessPrefabs_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>FindCrowdednessPrefabs_LambdaJob0_profilerMarker");
      ShowAiStateInfoSystem.NativeFieldInfoPtr__SingletonEntityQuery_ShowAi_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ShowAi_10));
      ShowAiStateInfoSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665610);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665611);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_CreateResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665612);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_DestroyResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665613);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665614);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_ShouldDrawAnything_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665615);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_FindAggroPrefabs_Private_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665616);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_FindAiStatePrefabs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665617);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_FindCrowdednessPrefabs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665618);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_FormatFloat_Private_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665619);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_FormatDouble_Private_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665620);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_CreateButtonsFromElements_Private_Void_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665621);
      ShowAiStateInfoSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665622);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665624);
      ShowAiStateInfoSystem.NativeMethodInfoPtr___GetEntityQuery_ForFindAggroPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665625);
      ShowAiStateInfoSystem.NativeMethodInfoPtr___GetEntityQuery_ForFindAiStatePrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665626);
      ShowAiStateInfoSystem.NativeMethodInfoPtr___GetEntityQuery_ForFindCrowdednessPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665627);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665628);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665629);
      ShowAiStateInfoSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, 100665630);
    }

    public ShowAiStateInfoSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Color LABEL_COLOR
    {
      get
      {
        Color labelColor;
        IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.NativeFieldInfoPtr_LABEL_COLOR, (void*) &labelColor);
        return labelColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.NativeFieldInfoPtr_LABEL_COLOR, (void*) &value);
      }
    }

    public unsafe GameObject _PickerButtonPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__PickerButtonPrefab));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__PickerButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<GameObject> _Instances
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__Instances));
        return pointer == System.IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__Instances), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject _CanvasGO
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__CanvasGO));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__CanvasGO), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<ShowAiStateInfoSystem.RectData> _Rects
    {
      get
      {
        return *(NativeList<ShowAiStateInfoSystem.RectData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__Rects));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__Rects), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ShowAiStateInfoSystem.RectData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<ShowAiStateInfoSystem.Element> _Elements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__Elements));
        return pointer == System.IntPtr.Zero ? (List<ShowAiStateInfoSystem.Element>) null : new List<ShowAiStateInfoSystem.Element>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__Elements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextGenerator _TextGenerator
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__TextGenerator));
        return pointer == System.IntPtr.Zero ? (TextGenerator) null : new TextGenerator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__TextGenerator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TextGenerationSettings _TextGenerationSettings
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__TextGenerationSettings);
        return new TextGenerationSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__TextGenerationSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe UserActivityGridSystem _UserActivityGridSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__UserActivityGridSystem));
        return pointer == System.IntPtr.Zero ? (UserActivityGridSystem) null : new UserActivityGridSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__UserActivityGridSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __FindAggroPrefabs_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAggroPrefabs_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAggroPrefabs_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FindAggroPrefabs_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAggroPrefabs_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAggroPrefabs_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __FindAiStatePrefabs_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAiStatePrefabs_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAiStatePrefabs_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FindAiStatePrefabs_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAiStatePrefabs_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindAiStatePrefabs_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __FindCrowdednessPrefabs_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindCrowdednessPrefabs_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindCrowdednessPrefabs_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FindCrowdednessPrefabs_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindCrowdednessPrefabs_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr___FindCrowdednessPrefabs_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ShowAi_10
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__SingletonEntityQuery_ShowAi_10));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.NativeFieldInfoPtr__SingletonEntityQuery_ShowAi_10)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RectData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ScreenRect;
      private static readonly System.IntPtr NativeFieldInfoPtr_ElementIndex;
      [FieldOffset(0)]
      public Rect ScreenRect;
      [FieldOffset(16)]
      public int ElementIndex;

      static RectData()
      {
        Il2CppClassPointerStore<ShowAiStateInfoSystem.RectData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (RectData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.RectData>.NativeClassPtr);
        ShowAiStateInfoSystem.RectData.NativeFieldInfoPtr_ScreenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.RectData>.NativeClassPtr, nameof (ScreenRect));
        ShowAiStateInfoSystem.RectData.NativeFieldInfoPtr_ElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.RectData>.NativeClassPtr, nameof (ElementIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.RectData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StateOnScreenPrefab
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_State;
      [FieldOffset(0)]
      public float3 WorldPosition;
      [FieldOffset(12)]
      public GenericEnemyState State;

      static StateOnScreenPrefab()
      {
        Il2CppClassPointerStore<ShowAiStateInfoSystem.StateOnScreenPrefab>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (StateOnScreenPrefab));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.StateOnScreenPrefab>.NativeClassPtr);
        ShowAiStateInfoSystem.StateOnScreenPrefab.NativeFieldInfoPtr_WorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.StateOnScreenPrefab>.NativeClassPtr, nameof (WorldPosition));
        ShowAiStateInfoSystem.StateOnScreenPrefab.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.StateOnScreenPrefab>.NativeClassPtr, nameof (State));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.StateOnScreenPrefab>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AggroOnScreenPrefab
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_AggroBufferElement;
      [FieldOffset(0)]
      public float3 WorldPosition;
      [FieldOffset(16)]
      public AggroBuffer AggroBufferElement;

      static AggroOnScreenPrefab()
      {
        Il2CppClassPointerStore<ShowAiStateInfoSystem.AggroOnScreenPrefab>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (AggroOnScreenPrefab));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.AggroOnScreenPrefab>.NativeClassPtr);
        ShowAiStateInfoSystem.AggroOnScreenPrefab.NativeFieldInfoPtr_WorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.AggroOnScreenPrefab>.NativeClassPtr, nameof (WorldPosition));
        ShowAiStateInfoSystem.AggroOnScreenPrefab.NativeFieldInfoPtr_AggroBufferElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.AggroOnScreenPrefab>.NativeClassPtr, nameof (AggroBufferElement));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.AggroOnScreenPrefab>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CrowdednessOnScreenPrefab
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_Value;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlayersInRange;
      [FieldOffset(0)]
      public float3 WorldPosition;
      [FieldOffset(12)]
      public float Value;
      [FieldOffset(16)]
      public int PlayersInRange;

      static CrowdednessOnScreenPrefab()
      {
        Il2CppClassPointerStore<ShowAiStateInfoSystem.CrowdednessOnScreenPrefab>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (CrowdednessOnScreenPrefab));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.CrowdednessOnScreenPrefab>.NativeClassPtr);
        ShowAiStateInfoSystem.CrowdednessOnScreenPrefab.NativeFieldInfoPtr_WorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.CrowdednessOnScreenPrefab>.NativeClassPtr, nameof (WorldPosition));
        ShowAiStateInfoSystem.CrowdednessOnScreenPrefab.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.CrowdednessOnScreenPrefab>.NativeClassPtr, nameof (Value));
        ShowAiStateInfoSystem.CrowdednessOnScreenPrefab.NativeFieldInfoPtr_PlayersInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.CrowdednessOnScreenPrefab>.NativeClassPtr, nameof (PlayersInRange));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.CrowdednessOnScreenPrefab>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class Element : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ScreenPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;

      static Element()
      {
        Il2CppClassPointerStore<ShowAiStateInfoSystem.Element>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, nameof (Element));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.Element>.NativeClassPtr);
        ShowAiStateInfoSystem.Element.NativeFieldInfoPtr_ScreenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.Element>.NativeClassPtr, nameof (ScreenPosition));
        ShowAiStateInfoSystem.Element.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.Element>.NativeClassPtr, nameof (Text));
      }

      public Element(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Element()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShowAiStateInfoSystem.Element>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.Element>.NativeClassPtr, data));
      }

      public unsafe float2 ScreenPosition
      {
        get
        {
          return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.Element.NativeFieldInfoPtr_ScreenPosition));
        }
        [param: In] set
        {
          *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.Element.NativeFieldInfoPtr_ScreenPosition)) = value;
        }
      }

      public unsafe string Text
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.Element.NativeFieldInfoPtr_Text)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.Element.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/<>c__DisplayClass21_0")]
    public sealed class __c__DisplayClass21_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_consumer;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabs;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__FindAggroPrefabs_b__0_Internal_Void_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass21_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass21_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _FindAggroPrefabs_b__0(
        DynamicBuffer<AggroBuffer> aggroBuffer,
        [In] ref AggroConsumer aggroConsumer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__FindAggroPrefabs_b__0_Internal_Void_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass21_0()
      {
        Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>c__DisplayClass21_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass21_0>.NativeClassPtr);
        ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeFieldInfoPtr_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass21_0>.NativeClassPtr, nameof (consumer));
        ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
        ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeFieldInfoPtr_prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass21_0>.NativeClassPtr, nameof (prefabs));
        ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass21_0>.NativeClassPtr, 100665631);
        ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__FindAggroPrefabs_b__0_Internal_Void_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass21_0>.NativeClassPtr, 100665632);
      }

      public __c__DisplayClass21_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass21_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass21_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass21_0>.NativeClassPtr, data));
      }

      public unsafe AggroConsumer consumer
      {
        get
        {
          return *(AggroConsumer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeFieldInfoPtr_consumer));
        }
        [param: In] set
        {
          *(AggroConsumer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeFieldInfoPtr_consumer)) = value;
        }
      }

      public unsafe ShowAiStateInfoSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ShowAiStateInfoSystem) null : new ShowAiStateInfoSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeList<ShowAiStateInfoSystem.AggroOnScreenPrefab> prefabs
      {
        get
        {
          return *(NativeList<ShowAiStateInfoSystem.AggroOnScreenPrefab>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeFieldInfoPtr_prefabs));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowAiStateInfoSystem.__c__DisplayClass21_0.NativeFieldInfoPtr_prefabs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ShowAiStateInfoSystem.AggroOnScreenPrefab>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/<>c__DisplayClass22_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass22_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabs;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__FindAiStatePrefabs_b__0_Internal_Void_byref_Translation_byref_BehaviourTreeState_0;
      [FieldOffset(0)]
      public NativeList<ShowAiStateInfoSystem.StateOnScreenPrefab> prefabs;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass22_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _FindAiStatePrefabs_b__0(
        [In] ref Translation translation,
        [In] ref BehaviourTreeState behaviourTreeState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref behaviourTreeState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__FindAiStatePrefabs_b__0_Internal_Void_byref_Translation_byref_BehaviourTreeState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass22_0()
      {
        Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>c__DisplayClass22_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass22_0>.NativeClassPtr);
        ShowAiStateInfoSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (prefabs));
        ShowAiStateInfoSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass22_0>.NativeClassPtr, 100665633);
        ShowAiStateInfoSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__FindAiStatePrefabs_b__0_Internal_Void_byref_Translation_byref_BehaviourTreeState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass22_0>.NativeClassPtr, 100665634);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass22_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/<>c__DisplayClass23_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass23_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_userActivityGrid;
      private static readonly System.IntPtr NativeFieldInfoPtr_userList;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabs;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__FindCrowdednessPrefabs_b__0_Internal_Void_Entity_byref_Translation_byref_Crowdedness_0;
      [FieldOffset(0)]
      public UserActivityGrid userActivityGrid;
      [FieldOffset(144)]
      public NativeList<int> userList;
      [FieldOffset(160)]
      public EntityManager entityManager;
      [FieldOffset(168)]
      public NativeList<ShowAiStateInfoSystem.CrowdednessOnScreenPrefab> prefabs;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass23_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _FindCrowdednessPrefabs_b__0(
        Entity entity,
        [In] ref Translation translation,
        [In] ref Crowdedness crowdedness)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref crowdedness;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__FindCrowdednessPrefabs_b__0_Internal_Void_Entity_byref_Translation_byref_Crowdedness_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass23_0()
      {
        Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>c__DisplayClass23_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass23_0>.NativeClassPtr);
        ShowAiStateInfoSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_userActivityGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (userActivityGrid));
        ShowAiStateInfoSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_userList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (userList));
        ShowAiStateInfoSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (entityManager));
        ShowAiStateInfoSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (prefabs));
        ShowAiStateInfoSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass23_0>.NativeClassPtr, 100665635);
        ShowAiStateInfoSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__FindCrowdednessPrefabs_b__0_Internal_Void_Entity_byref_Translation_byref_Crowdedness_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass23_0>.NativeClassPtr, 100665636);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass23_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/ProjectM.Behaviours.Editor.<>c__DisplayClass_FindAggroPrefabs_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FindAggroPrefabs_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_consumer;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabs;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public AggroConsumer consumer;
      [FieldOffset(80)]
      public NativeList<ShowAiStateInfoSystem.AggroOnScreenPrefab> prefabs;
      [FieldOffset(96)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;
      [FieldOffset(128)]
      public ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(200)]
      public unsafe ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346382, XrefRangeEnd = 1346396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        DynamicBuffer<AggroBuffer> aggroBuffer,
        [In] ref AggroConsumer aggroConsumer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1346396, RefRangeEnd = 1346397, XrefRangeStart = 1346396, XrefRangeEnd = 1346396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ShowAiStateInfoSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1346397, RefRangeEnd = 1346398, XrefRangeStart = 1346397, XrefRangeEnd = 1346397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ShowAiStateInfoSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346398, XrefRangeEnd = 1346400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1346408, RefRangeEnd = 1346409, XrefRangeStart = 1346400, XrefRangeEnd = 1346408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1346414, RefRangeEnd = 1346415, XrefRangeStart = 1346409, XrefRangeEnd = 1346414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ShowAiStateInfoSystem componentSystem,
        ref ShowAiStateInfoSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346415, XrefRangeEnd = 1346419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346419, XrefRangeEnd = 1346425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FindAggroPrefabs_LambdaJob0()
      {
        Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>c__DisplayClass_FindAggroPrefabs_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeFieldInfoPtr_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, nameof (consumer));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeFieldInfoPtr_prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, nameof (prefabs));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, 100665637);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, 100665638);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, 100665639);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, 100665640);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, 100665641);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, 100665642);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, 100665643);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, 100665644);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroConsumer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_aggroConsumer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1346299, RefRangeEnd = 1346300, XrefRangeStart = 1346293, XrefRangeEnd = 1346299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ShowAiStateInfoSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1346306, RefRangeEnd = 1346307, XrefRangeStart = 1346300, XrefRangeEnd = 1346306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroConsumer));
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665645);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665646);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroConsumer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_aggroConsumer;

          static Runtimes()
          {
            Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
            ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroConsumer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/ProjectM.Behaviours.Editor.<>c__DisplayClass_FindAggroPrefabs_LambdaJob0/ProjectM.Behaviours.Editor.RunWithoutJobSystem_00000754$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000754$PostfixBurstDelegate");
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665647);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665648);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665649);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665650);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/ProjectM.Behaviours.Editor.<>c__DisplayClass_FindAggroPrefabs_LambdaJob0/ProjectM.Behaviours.Editor.RunWithoutJobSystem_00000754$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346307, XrefRangeEnd = 1346321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346321, XrefRangeEnd = 1346339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346339, XrefRangeEnd = 1346354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1346381, RefRangeEnd = 1346382, XrefRangeStart = 1346354, XrefRangeEnd = 1346381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000754$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665651);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665652);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665653);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665654);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665656);
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
            IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAggroPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/ProjectM.Behaviours.Editor.<>c__DisplayClass_FindAiStatePrefabs_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FindAiStatePrefabs_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabs;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Translation_byref_BehaviourTreeState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<ShowAiStateInfoSystem.StateOnScreenPrefab> prefabs;
      [FieldOffset(16)]
      public ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346514, XrefRangeEnd = 1346517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref Translation translation,
        [In] ref BehaviourTreeState behaviourTreeState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref behaviourTreeState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Translation_byref_BehaviourTreeState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ShowAiStateInfoSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ShowAiStateInfoSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346517, XrefRangeEnd = 1346519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1346527, RefRangeEnd = 1346528, XrefRangeStart = 1346519, XrefRangeEnd = 1346527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1346530, RefRangeEnd = 1346531, XrefRangeStart = 1346528, XrefRangeEnd = 1346530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ShowAiStateInfoSystem componentSystem,
        ref ShowAiStateInfoSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346531, XrefRangeEnd = 1346535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346535, XrefRangeEnd = 1346541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FindAiStatePrefabs_LambdaJob0()
      {
        Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>c__DisplayClass_FindAiStatePrefabs_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeFieldInfoPtr_prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, nameof (prefabs));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Translation_byref_BehaviourTreeState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, 100665657);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, 100665658);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, 100665659);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, 100665660);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, 100665661);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, 100665662);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, 100665663);
        ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, 100665664);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_behaviourTreeState;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<BehaviourTreeState> forParameter_behaviourTreeState;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1346431, RefRangeEnd = 1346432, XrefRangeStart = 1346425, XrefRangeEnd = 1346431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ShowAiStateInfoSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1346438, RefRangeEnd = 1346439, XrefRangeStart = 1346432, XrefRangeEnd = 1346438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_behaviourTreeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_behaviourTreeState));
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665665);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665666);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_behaviourTreeState;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<BehaviourTreeState>.Runtime runtime_behaviourTreeState;

          static Runtimes()
          {
            Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_behaviourTreeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_behaviourTreeState));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/ProjectM.Behaviours.Editor.<>c__DisplayClass_FindAiStatePrefabs_LambdaJob0/ProjectM.Behaviours.Editor.RunWithoutJobSystem_0000075D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000075D$PostfixBurstDelegate");
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665667);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665668);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665669);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665670);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/ProjectM.Behaviours.Editor.<>c__DisplayClass_FindAiStatePrefabs_LambdaJob0/ProjectM.Behaviours.Editor.RunWithoutJobSystem_0000075D$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346439, XrefRangeEnd = 1346453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346453, XrefRangeEnd = 1346471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346471, XrefRangeEnd = 1346486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1346513, RefRangeEnd = 1346514, XrefRangeStart = 1346486, XrefRangeEnd = 1346513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000075D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665671);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665672);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665673);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665674);
          ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665676);
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
            IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindAiStatePrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/ProjectM.Behaviours.Editor.<>c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_userActivityGrid;
      private static readonly System.IntPtr NativeFieldInfoPtr_userList;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabs;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_byref_Crowdedness_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_byref___c__DisplayClass23_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public UserActivityGrid userActivityGrid;
      [FieldOffset(144)]
      public NativeList<int> userList;
      [FieldOffset(160)]
      public EntityManager entityManager;
      [FieldOffset(168)]
      public NativeList<ShowAiStateInfoSystem.CrowdednessOnScreenPrefab> prefabs;
      [FieldOffset(184)]
      public ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(256)]
      public unsafe ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346632, XrefRangeEnd = 1346645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Translation translation,
        [In] ref Crowdedness crowdedness)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref crowdedness;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_byref_Crowdedness_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1346645, RefRangeEnd = 1346646, XrefRangeStart = 1346645, XrefRangeEnd = 1346645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ShowAiStateInfoSystem.__c__DisplayClass23_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1346646, RefRangeEnd = 1346647, XrefRangeStart = 1346646, XrefRangeEnd = 1346646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ShowAiStateInfoSystem.__c__DisplayClass23_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346647, XrefRangeEnd = 1346649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1346658, RefRangeEnd = 1346659, XrefRangeStart = 1346649, XrefRangeEnd = 1346658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1346661, RefRangeEnd = 1346662, XrefRangeStart = 1346659, XrefRangeEnd = 1346661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ShowAiStateInfoSystem componentSystem,
        ref ShowAiStateInfoSystem.__c__DisplayClass23_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_byref___c__DisplayClass23_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346662, XrefRangeEnd = 1346666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346666, XrefRangeEnd = 1346672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0()
      {
        Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem>.NativeClassPtr, "<>c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr);
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr_userActivityGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, nameof (userActivityGrid));
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr_userList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, nameof (userList));
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr_prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, nameof (prefabs));
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_byref_Crowdedness_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, 100665677);
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, 100665678);
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, 100665679);
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, 100665680);
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, 100665681);
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_byref___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, 100665682);
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, 100665683);
        ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, 100665684);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_crowdedness;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Crowdedness> forParameter_crowdedness;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1346548, RefRangeEnd = 1346549, XrefRangeStart = 1346541, XrefRangeEnd = 1346548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ShowAiStateInfoSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1346556, RefRangeEnd = 1346557, XrefRangeStart = 1346549, XrefRangeEnd = 1346556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_crowdedness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_crowdedness));
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowAiStateInfoSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665685);
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665686);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_crowdedness;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Crowdedness>.Runtime runtime_crowdedness;

          static Runtimes()
          {
            Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_crowdedness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_crowdedness));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/ProjectM.Behaviours.Editor.<>c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0/ProjectM.Behaviours.Editor.RunWithoutJobSystem_00000766$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000766$PostfixBurstDelegate");
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665687);
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665688);
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665689);
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665690);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.Editor.ShowAiStateInfoSystem/ProjectM.Behaviours.Editor.<>c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0/ProjectM.Behaviours.Editor.RunWithoutJobSystem_00000766$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346557, XrefRangeEnd = 1346571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346571, XrefRangeEnd = 1346589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346589, XrefRangeEnd = 1346604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1346631, RefRangeEnd = 1346632, XrefRangeStart = 1346604, XrefRangeEnd = 1346631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000766$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665691);
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665692);
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665693);
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665694);
          ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665696);
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
            IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ShowAiStateInfoSystem.__c__DisplayClass_FindCrowdednessPrefabs_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
