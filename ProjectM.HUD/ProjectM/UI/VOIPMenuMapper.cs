// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VOIPMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.UI
{
  public class VOIPMenuMapper : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__UIDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Menu;
    private static readonly System.IntPtr NativeFieldInfoPtr_VOIPEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConnectClicked_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisconnectClicked_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__7_0_Private_Void_Entity_VOIPMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288448, XrefRangeEnd = 1288467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VOIPMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288467, XrefRangeEnd = 1288481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VOIPMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288481, XrefRangeEnd = 1288485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConnectClicked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.NativeMethodInfoPtr_ConnectClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288485, XrefRangeEnd = 1288489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisconnectClicked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.NativeMethodInfoPtr_DisconnectClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288489, XrefRangeEnd = 1288514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VOIPMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VOIPMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1288534, RefRangeEnd = 1288535, XrefRangeStart = 1288514, XrefRangeEnd = 1288534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__7_0(Entity entity, VOIPMenu menu)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__7_0_Private_Void_Entity_VOIPMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288535, XrefRangeEnd = 1288564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VOIPMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288564, XrefRangeEnd = 1288580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnStartRunning_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static VOIPMenuMapper()
    {
      Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VOIPMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr);
      VOIPMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, nameof (_Query));
      VOIPMenuMapper.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, nameof (_InputSystem));
      VOIPMenuMapper.NativeFieldInfoPtr__UIDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, nameof (_UIDataSystem));
      VOIPMenuMapper.NativeFieldInfoPtr__Menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, nameof (_Menu));
      VOIPMenuMapper.NativeFieldInfoPtr_VOIPEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, nameof (VOIPEntity));
      VOIPMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, "<>OnStartRunning_LambdaJob0_entityQuery");
      VOIPMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, "<>OnStartRunning_LambdaJob0_profilerMarker");
      VOIPMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, 100669666);
      VOIPMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, 100669667);
      VOIPMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, 100669668);
      VOIPMenuMapper.NativeMethodInfoPtr_ConnectClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, 100669669);
      VOIPMenuMapper.NativeMethodInfoPtr_DisconnectClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, 100669670);
      VOIPMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, 100669671);
      VOIPMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, 100669672);
      VOIPMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, 100669673);
      VOIPMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__7_0_Private_Void_Entity_VOIPMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, 100669674);
      VOIPMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, 100669675);
      VOIPMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, 100669676);
    }

    public VOIPMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIDataSystem _UIDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr__UIDataSystem));
        return pointer == System.IntPtr.Zero ? (UIDataSystem) null : new UIDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr__UIDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VOIPMenu _Menu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr__Menu));
        return pointer == System.IntPtr.Zero ? (VOIPMenu) null : new VOIPMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr__Menu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity VOIPEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr_VOIPEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr_VOIPEntity)) = value;
      }
    }

    public unsafe EntityQuery __OnStartRunning_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnStartRunning_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.VOIPMenuMapper/ProjectM.UI.<>c__DisplayClass_OnStartRunning_LambdaJob0")]
    public sealed class __c__DisplayClass_OnStartRunning_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_VOIPMenu_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VOIPMenuMapper_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1288429, RefRangeEnd = 1288430, XrefRangeStart = 1288427, XrefRangeEnd = 1288429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, VOIPMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_VOIPMenu_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288430, XrefRangeEnd = 1288432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1288438, RefRangeEnd = 1288439, XrefRangeStart = 1288432, XrefRangeEnd = 1288438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1288441, RefRangeEnd = 1288442, XrefRangeStart = 1288439, XrefRangeEnd = 1288441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(VOIPMenuMapper componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VOIPMenuMapper_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288442, XrefRangeEnd = 1288448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnStartRunning_LambdaJob0()
      {
        Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VOIPMenuMapper>.NativeClassPtr, "<>c__DisplayClass_OnStartRunning_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr);
        VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_VOIPMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100669677);
        VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100669678);
        VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100669679);
        VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VOIPMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100669680);
        VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100669681);
      }

      public __c__DisplayClass_OnStartRunning_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnStartRunning_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe VOIPMenuMapper hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (VOIPMenuMapper) null : new VOIPMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_menu;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VOIPMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<VOIPMenu> forParameter_menu;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1288420, RefRangeEnd = 1288421, XrefRangeStart = 1288416, XrefRangeEnd = 1288420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VOIPMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VOIPMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1288426, RefRangeEnd = 1288427, XrefRangeStart = 1288421, XrefRangeEnd = 1288426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_menu));
          VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VOIPMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100669682);
          VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100669683);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_menu;

          static Runtimes()
          {
            Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_menu));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public unsafe LambdaParameterValueProvider_Entity.Runtime runtime_entity
          {
            get
            {
              return *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity));
            }
            [param: In] set
            {
              *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity)) = value;
            }
          }

          public LambdaParameterValueProvider_ManagedComponentData<VOIPMenu>.Runtime runtime_menu
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu);
              return new LambdaParameterValueProvider_ManagedComponentData<VOIPMenu>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<VOIPMenu>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<VOIPMenu>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }
  }
}
