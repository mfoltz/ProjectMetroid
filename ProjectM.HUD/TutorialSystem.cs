// Decompiled with JetBrains decompiler
// Type: TutorialSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.UI;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
public class TutorialSystem : SystemBase
{
  private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr__TutorialParent;
  private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr__InputState;
  private static readonly System.IntPtr NativeFieldInfoPtr__UsedCameraTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr__InventorySubMenu;
  private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
  private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
  private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery;
  private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery;
  private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_0;
  private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_1;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__13_0_Private_Void_Entity_UICanvasBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__13_1_Private_Void_Entity_InventorySubMenu_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206664, XrefRangeEnd = 1206694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206694, XrefRangeEnd = 1206696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnStartRunning()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206696, XrefRangeEnd = 1206699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnStopRunning()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206699, XrefRangeEnd = 1206707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
    IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206707, XrefRangeEnd = 1206708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void HandleInput(InputState inputState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &inputState;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206708, XrefRangeEnd = 1207025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207025, XrefRangeEnd = 1207026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1207035, RefRangeEnd = 1207037, XrefRangeStart = 1207026, XrefRangeEnd = 1207035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _OnUpdate_b__13_0(Entity entity, UICanvasBase canvasBase)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &entity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvasBase);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr__OnUpdate_b__13_0_Private_Void_Entity_UICanvasBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1207042, RefRangeEnd = 1207043, XrefRangeStart = 1207037, XrefRangeEnd = 1207042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _OnUpdate_b__13_1(Entity menuEntity, InventorySubMenu menu)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &menuEntity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr__OnUpdate_b__13_1_Private_Void_Entity_InventorySubMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207043, XrefRangeEnd = 1207164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreateForCompiler()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207164, XrefRangeEnd = 1207180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
    ComponentSystemBase componentSystem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207180, XrefRangeEnd = 1207196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
    ComponentSystemBase componentSystem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207196, XrefRangeEnd = 1207215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob2_From(
    ComponentSystemBase componentSystem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207215, XrefRangeEnd = 1207234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob3_From(
    ComponentSystemBase componentSystem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
  }

  static TutorialSystem()
  {
    Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (TutorialSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr);
    TutorialSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
    TutorialSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (_GameDataSystem));
    TutorialSystem.NativeFieldInfoPtr__TutorialParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (_TutorialParent));
    TutorialSystem.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (_InputSystem));
    TutorialSystem.NativeFieldInfoPtr__InputState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (_InputState));
    TutorialSystem.NativeFieldInfoPtr__UsedCameraTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (_UsedCameraTimer));
    TutorialSystem.NativeFieldInfoPtr__InventorySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (_InventorySubMenu));
    TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
    TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
    TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
    TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
    TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob2_entityQuery");
    TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob2_profilerMarker");
    TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob3_entityQuery");
    TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob3_profilerMarker");
    TutorialSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalCharacter_0));
    TutorialSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalUser_1));
    TutorialSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663412);
    TutorialSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663413);
    TutorialSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663414);
    TutorialSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663415);
    TutorialSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663416);
    TutorialSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663417);
    TutorialSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663418);
    TutorialSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663419);
    TutorialSystem.NativeMethodInfoPtr__OnUpdate_b__13_0_Private_Void_Entity_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663420);
    TutorialSystem.NativeMethodInfoPtr__OnUpdate_b__13_1_Private_Void_Entity_InventorySubMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663421);
    TutorialSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663422);
    TutorialSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663423);
    TutorialSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663424);
    TutorialSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663425);
    TutorialSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100663426);
  }

  public TutorialSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe PrefabCollectionSystem _PrefabCollectionSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
      return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameDataSystem _GameDataSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__GameDataSystem));
      return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TutorialParent _TutorialParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__TutorialParent));
      return pointer == System.IntPtr.Zero ? (TutorialParent) null : new TutorialParent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__TutorialParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputSystem _InputSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__InputSystem));
      return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputState _InputState
  {
    get
    {
      return *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__InputState));
    }
    [param: In] set
    {
      *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__InputState)) = value;
    }
  }

  public unsafe float _UsedCameraTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__UsedCameraTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__UsedCameraTimer)) = value;
    }
  }

  public unsafe InventorySubMenu _InventorySubMenu
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__InventorySubMenu));
      return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__InventorySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
    }
  }

  public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
  {
    get
    {
      return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
    }
    [param: In] set
    {
      *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
    }
  }

  public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
    }
  }

  public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
  {
    get
    {
      return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
    }
    [param: In] set
    {
      *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
    }
  }

  public unsafe EntityQuery __OnUpdate_LambdaJob2_entityQuery
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery)) = value;
    }
  }

  public unsafe ProfilerMarker __OnUpdate_LambdaJob2_profilerMarker
  {
    get
    {
      return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker));
    }
    [param: In] set
    {
      *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker)) = value;
    }
  }

  public unsafe EntityQuery __OnUpdate_LambdaJob3_entityQuery
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery)) = value;
    }
  }

  public unsafe ProfilerMarker __OnUpdate_LambdaJob3_profilerMarker
  {
    get
    {
      return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker));
    }
    [param: In] set
    {
      *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker)) = value;
    }
  }

  public unsafe EntityQuery _SingletonEntityQuery_LocalCharacter_0
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_0));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_0)) = value;
    }
  }

  public unsafe EntityQuery _SingletonEntityQuery_LocalUser_1
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_1));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_1)) = value;
    }
  }

  [ObfuscatedName("TutorialSystem/<>c__DisplayClass13_0")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass13_0
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_playerTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_addQuest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0;
    [FieldOffset(0)]
    public Translation playerTranslation;
    [FieldOffset(12)]
    public bool addQuest;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass13_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__2(
      Entity entity,
      [In] ref LocalToWorld localToWorld,
      [In] ref TutorialPointPosition tutorialPointPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tutorialPointPosition;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass13_0()
    {
      Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>c__DisplayClass13_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_0>.NativeClassPtr);
      TutorialSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_playerTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (playerTranslation));
      TutorialSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_addQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (addQuest));
      TutorialSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_0>.NativeClassPtr, 100663427);
      TutorialSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_0>.NativeClassPtr, 100663428);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_0>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("TutorialSystem/<>c__DisplayClass13_1")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass13_1
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_playerTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_addQuest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0;
    [FieldOffset(0)]
    public Translation playerTranslation;
    [FieldOffset(12)]
    public bool addQuest;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass13_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__3(
      Entity entity,
      [In] ref LocalToWorld localToWorld,
      [In] ref TutorialPointPosition tutorialPointPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tutorialPointPosition;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass13_1.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass13_1()
    {
      Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>c__DisplayClass13_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_1>.NativeClassPtr);
      TutorialSystem.__c__DisplayClass13_1.NativeFieldInfoPtr_playerTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_1>.NativeClassPtr, nameof (playerTranslation));
      TutorialSystem.__c__DisplayClass13_1.NativeFieldInfoPtr_addQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_1>.NativeClassPtr, nameof (addQuest));
      TutorialSystem.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_1>.NativeClassPtr, 100663429);
      TutorialSystem.__c__DisplayClass13_1.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_1>.NativeClassPtr, 100663430);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass13_1>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("TutorialSystem/<>c__DisplayClass_OnUpdate_LambdaJob0")]
  public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
    private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
    private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
    private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206527, XrefRangeEnd = 1206529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OriginalLambdaBody(Entity entity, UICanvasBase canvasBase)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvasBase);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206529, XrefRangeEnd = 1206541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) jobStructPtr;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1206547, RefRangeEnd = 1206548, XrefRangeStart = 1206541, XrefRangeEnd = 1206547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleTimeInitialize(TutorialSystem componentSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass_OnUpdate_LambdaJob0()
    {
      Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663431);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663433);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663434);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663435);
    }

    public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public __c__DisplayClass_OnUpdate_LambdaJob0()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
    }

    public unsafe TutorialSystem hostInstance
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance));
        return pointer == System.IntPtr.Zero ? (TutorialSystem) null : new TutorialSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
    {
      get
      {
        return *(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
      }
      [param: In] set
      {
        *(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
      }
    }

    public unsafe TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
    {
      get
      {
        return (TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
      }
    }

    public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LambdaParameterValueProviders
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_canvasBase;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
      [FieldOffset(0)]
      public LambdaParameterValueProvider_Entity forParameter_entity;
      [FieldOffset(8)]
      public LambdaParameterValueProvider_ManagedComponentData<UICanvasBase> forParameter_canvasBase;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206517, XrefRangeEnd = 1206521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(TutorialSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1206526, RefRangeEnd = 1206527, XrefRangeStart = 1206521, XrefRangeEnd = 1206526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
        ComponentSystemBase p0,
        EntityQuery p1)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
      }

      static LambdaParameterValueProviders()
      {
        Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_canvasBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_canvasBase));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663436);
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663437);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct Runtimes
      {
        private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_canvasBase;
        [FieldOffset(0)]
        public StructuralChangeEntityProvider _entityProvider;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.StructuralChangeRuntime runtime_canvasBase;

        static Runtimes()
        {
          Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
          TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
          TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvasBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_canvasBase));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }
  }

  [ObfuscatedName("TutorialSystem/<>c__DisplayClass_OnUpdate_LambdaJob1")]
  public sealed class __c__DisplayClass_OnUpdate_LambdaJob1 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
    private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
    private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_InventorySubMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1206561, RefRangeEnd = 1206562, XrefRangeStart = 1206559, XrefRangeEnd = 1206561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OriginalLambdaBody(Entity menuEntity, InventorySubMenu menu)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &menuEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_InventorySubMenu_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206562, XrefRangeEnd = 1206564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1206570, RefRangeEnd = 1206571, XrefRangeStart = 1206564, XrefRangeEnd = 1206570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IterateEntities(
      ref ArchetypeChunk chunk,
      ref TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1206573, RefRangeEnd = 1206574, XrefRangeStart = 1206571, XrefRangeEnd = 1206573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleTimeInitialize(TutorialSystem componentSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206574, XrefRangeEnd = 1206580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunWithoutJobSystem(
      ArchetypeChunkIterator* archetypeChunkIterator,
      void* jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass_OnUpdate_LambdaJob1()
    {
      Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (hostInstance));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_InventorySubMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663438);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663439);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663440);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663441);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663442);
    }

    public __c__DisplayClass_OnUpdate_LambdaJob1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public __c__DisplayClass_OnUpdate_LambdaJob1()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, data));
    }

    public unsafe TutorialSystem hostInstance
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_hostInstance));
        return pointer == System.IntPtr.Zero ? (TutorialSystem) null : new TutorialSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders
    {
      get
      {
        return *(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders));
      }
      [param: In] set
      {
        *(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
      }
    }

    public unsafe TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes
    {
      get
      {
        return (TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
      }
    }

    public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LambdaParameterValueProviders
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_menuEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_menu;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public LambdaParameterValueProvider_Entity forParameter_menuEntity;
      [FieldOffset(8)]
      public LambdaParameterValueProvider_ManagedComponentData<InventorySubMenu> forParameter_menu;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1206552, RefRangeEnd = 1206553, XrefRangeStart = 1206548, XrefRangeEnd = 1206552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(TutorialSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1206558, RefRangeEnd = 1206559, XrefRangeStart = 1206553, XrefRangeEnd = 1206558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
        ref ArchetypeChunk p0,
        int p1,
        int p2)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref p0;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes(pointer);
      }

      static LambdaParameterValueProviders()
      {
        Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_menuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_menuEntity));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_menu));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100663443);
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100663444);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public sealed class Runtimes : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_menuEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_menu;

        static Runtimes()
        {
          Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
          TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_menuEntity));
          TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_menu));
        }

        public Runtimes(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public Runtimes()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
        }

        public unsafe LambdaParameterValueProvider_Entity.Runtime runtime_menuEntity
        {
          get
          {
            return *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menuEntity));
          }
          [param: In] set
          {
            *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menuEntity)) = value;
          }
        }

        public LambdaParameterValueProvider_ManagedComponentData<InventorySubMenu>.Runtime runtime_menu
        {
          get
          {
            System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu);
            return new LambdaParameterValueProvider_ManagedComponentData<InventorySubMenu>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<InventorySubMenu>.Runtime>.NativeClassPtr, data));
          }
          [param: In] set
          {
            __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<InventorySubMenu>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          }
        }
      }
    }
  }

  [ObfuscatedName("TutorialSystem/<>c__DisplayClass_OnUpdate_LambdaJob2")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass_OnUpdate_LambdaJob2
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_playerTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_addQuest;
    private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
    private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
    private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_byref___c__DisplayClass13_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
    [FieldOffset(0)]
    public Translation playerTranslation;
    [FieldOffset(12)]
    public bool addQuest;
    [FieldOffset(16)]
    public TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
    [FieldOffset(88)]
    public unsafe TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1206597, RefRangeEnd = 1206598, XrefRangeStart = 1206596, XrefRangeEnd = 1206597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OriginalLambdaBody(
      Entity entity,
      [In] ref LocalToWorld localToWorld,
      [In] ref TutorialPointPosition tutorialPointPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tutorialPointPosition;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1206598, RefRangeEnd = 1206601, XrefRangeStart = 1206598, XrefRangeEnd = 1206598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ReadFromDisplayClass(
      ref TutorialSystem.__c__DisplayClass13_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1206601, RefRangeEnd = 1206604, XrefRangeStart = 1206601, XrefRangeEnd = 1206601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void WriteToDisplayClass(
      ref TutorialSystem.__c__DisplayClass13_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206604, XrefRangeEnd = 1206606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1206615, RefRangeEnd = 1206616, XrefRangeStart = 1206606, XrefRangeEnd = 1206615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IterateEntities(
      ref ArchetypeChunk chunk,
      ref TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1206618, RefRangeEnd = 1206619, XrefRangeStart = 1206616, XrefRangeEnd = 1206618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleTimeInitialize(
      TutorialSystem componentSystem,
      ref TutorialSystem.__c__DisplayClass13_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206619, XrefRangeEnd = 1206625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunWithoutJobSystem(
      ArchetypeChunkIterator* archetypeChunkIterator,
      void* jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass_OnUpdate_LambdaJob2()
    {
      Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob2");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_playerTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (playerTranslation));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_addQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (addQuest));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663445);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663446);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663447);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663448);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663449);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663450);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663451);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LambdaParameterValueProviders
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localToWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tutorialPointPosition;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public LambdaParameterValueProvider_Entity forParameter_entity;
      [FieldOffset(8)]
      public LambdaParameterValueProvider_IComponentData<LocalToWorld> forParameter_localToWorld;
      [FieldOffset(40)]
      public LambdaParameterValueProvider_IComponentData<TutorialPointPosition> forParameter_tutorialPointPosition;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1206587, RefRangeEnd = 1206588, XrefRangeStart = 1206580, XrefRangeEnd = 1206587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(TutorialSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1206595, RefRangeEnd = 1206596, XrefRangeStart = 1206588, XrefRangeEnd = 1206595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
        ref ArchetypeChunk p0,
        int p1,
        int p2)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref p0;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
      }

      static LambdaParameterValueProviders()
      {
        Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localToWorld));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tutorialPointPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tutorialPointPosition));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100663452);
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100663453);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct Runtimes
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localToWorld;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tutorialPointPosition;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<LocalToWorld>.Runtime runtime_localToWorld;
        [FieldOffset(16)]
        public LambdaParameterValueProvider_IComponentData<TutorialPointPosition>.Runtime runtime_tutorialPointPosition;

        static Runtimes()
        {
          Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
          TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localToWorld));
          TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tutorialPointPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tutorialPointPosition));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }
  }

  [ObfuscatedName("TutorialSystem/<>c__DisplayClass_OnUpdate_LambdaJob3")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass_OnUpdate_LambdaJob3
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_playerTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_addQuest;
    private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
    private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
    private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_byref___c__DisplayClass13_1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
    [FieldOffset(0)]
    public Translation playerTranslation;
    [FieldOffset(12)]
    public bool addQuest;
    [FieldOffset(16)]
    public TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders _lambdaParameterValueProviders;
    [FieldOffset(88)]
    public unsafe TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes* _runtimes;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1206642, RefRangeEnd = 1206643, XrefRangeStart = 1206641, XrefRangeEnd = 1206642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OriginalLambdaBody(
      Entity entity,
      [In] ref LocalToWorld localToWorld,
      [In] ref TutorialPointPosition tutorialPointPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tutorialPointPosition;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1206598, RefRangeEnd = 1206601, XrefRangeStart = 1206598, XrefRangeEnd = 1206601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ReadFromDisplayClass(
      ref TutorialSystem.__c__DisplayClass13_1 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1206601, RefRangeEnd = 1206604, XrefRangeStart = 1206601, XrefRangeEnd = 1206604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void WriteToDisplayClass(
      ref TutorialSystem.__c__DisplayClass13_1 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206643, XrefRangeEnd = 1206645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1206654, RefRangeEnd = 1206655, XrefRangeStart = 1206645, XrefRangeEnd = 1206654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IterateEntities(
      ref ArchetypeChunk chunk,
      ref TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes runtimes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1206657, RefRangeEnd = 1206658, XrefRangeStart = 1206655, XrefRangeEnd = 1206657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleTimeInitialize(
      TutorialSystem componentSystem,
      ref TutorialSystem.__c__DisplayClass13_1 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_byref___c__DisplayClass13_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206658, XrefRangeEnd = 1206664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunWithoutJobSystem(
      ArchetypeChunkIterator* archetypeChunkIterator,
      void* jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass_OnUpdate_LambdaJob3()
    {
      Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob3");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_playerTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (playerTranslation));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_addQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (addQuest));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (_runtimes));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LocalToWorld_byref_TutorialPointPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100663454);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100663455);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100663456);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100663457);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100663458);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_byref___c__DisplayClass13_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100663459);
      TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100663460);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LambdaParameterValueProviders
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localToWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tutorialPointPosition;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public LambdaParameterValueProvider_Entity forParameter_entity;
      [FieldOffset(8)]
      public LambdaParameterValueProvider_IComponentData<LocalToWorld> forParameter_localToWorld;
      [FieldOffset(40)]
      public LambdaParameterValueProvider_IComponentData<TutorialPointPosition> forParameter_tutorialPointPosition;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1206632, RefRangeEnd = 1206633, XrefRangeStart = 1206625, XrefRangeEnd = 1206632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(TutorialSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1206640, RefRangeEnd = 1206641, XrefRangeStart = 1206633, XrefRangeEnd = 1206640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
        ref ArchetypeChunk p0,
        int p1,
        int p2)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref p0;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
      }

      static LambdaParameterValueProviders()
      {
        Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (LambdaParameterValueProviders));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localToWorld));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tutorialPointPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tutorialPointPosition));
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TutorialSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100663461);
        TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100663462);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct Runtimes
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localToWorld;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tutorialPointPosition;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<LocalToWorld>.Runtime runtime_localToWorld;
        [FieldOffset(16)]
        public LambdaParameterValueProvider_IComponentData<TutorialPointPosition>.Runtime runtime_tutorialPointPosition;

        static Runtimes()
        {
          Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
          TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localToWorld));
          TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tutorialPointPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tutorialPointPosition));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }
  }
}
