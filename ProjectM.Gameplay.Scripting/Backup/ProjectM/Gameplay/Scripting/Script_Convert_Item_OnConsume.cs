// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Convert_Item_OnConsume
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Scripting;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_Convert_Item_OnConsume : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_InputType;
    private static readonly IntPtr NativeFieldInfoPtr_PlacementCheckPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_HandleConsumableStack;
    private static readonly IntPtr NativeFieldInfoPtr_ConvertSequence;
    private static readonly IntPtr NativeFieldInfoPtr_FailedConvertSequence;
    private static readonly IntPtr NativeFieldInfoPtr_ConvertOutputs;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175200, XrefRangeEnd = 1175222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Convert_Item_OnConsume.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Convert_Item_OnConsume()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Convert_Item_OnConsume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Convert_Item_OnConsume()
    {
      Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Convert_Item_OnConsume));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr);
      Script_Convert_Item_OnConsume.NativeFieldInfoPtr_InputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr, nameof (InputType));
      Script_Convert_Item_OnConsume.NativeFieldInfoPtr_PlacementCheckPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr, nameof (PlacementCheckPrefab));
      Script_Convert_Item_OnConsume.NativeFieldInfoPtr_HandleConsumableStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr, nameof (HandleConsumableStack));
      Script_Convert_Item_OnConsume.NativeFieldInfoPtr_ConvertSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr, nameof (ConvertSequence));
      Script_Convert_Item_OnConsume.NativeFieldInfoPtr_FailedConvertSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr, nameof (FailedConvertSequence));
      Script_Convert_Item_OnConsume.NativeFieldInfoPtr_ConvertOutputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr, nameof (ConvertOutputs));
      Script_Convert_Item_OnConsume.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr, 100663389);
      Script_Convert_Item_OnConsume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr, 100663390);
    }

    public Script_Convert_Item_OnConsume(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent InputType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_InputType));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_InputType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent PlacementCheckPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_PlacementCheckPrefab));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_PlacementCheckPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool HandleConsumableStack
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_HandleConsumableStack));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_HandleConsumableStack)) = value;
      }
    }

    public unsafe SequenceField ConvertSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_ConvertSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_ConvertSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField FailedConvertSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_FailedConvertSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_FailedConvertSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Script_Convert_Item_OnConsume_Entry_Editor> ConvertOutputs
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_ConvertOutputs));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Script_Convert_Item_OnConsume_Entry_Editor>) null : new Il2CppReferenceArray<Script_Convert_Item_OnConsume_Entry_Editor>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume.NativeFieldInfoPtr_ConvertOutputs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_OnGetPlacementResult_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_PlacementResult_0;
      private static readonly IntPtr NativeMethodInfoPtr_AddResultItem_Private_Static_Boolean_ServerGameManager_SelfServer_Entity_Script_Convert_Item_OnConsume_DataServer_Script_Convert_Item_OnConsume_Entry_float3_quaternion_byref_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175112, XrefRangeEnd = 1175151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Convert_Item_OnConsume.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175151, XrefRangeEnd = 1175183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnGetPlacementResult(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        PlacementResult placementResult)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &placementResult;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Convert_Item_OnConsume.Server.NativeMethodInfoPtr_OnGetPlacementResult_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_PlacementResult_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1175198, RefRangeEnd = 1175200, XrefRangeStart = 1175183, XrefRangeEnd = 1175198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool AddResultItem(
        ServerGameManager game,
        SelfServer self,
        Entity owner,
        Script_Convert_Item_OnConsume_DataServer data,
        Script_Convert_Item_OnConsume_Entry entry,
        float3 position,
        quaternion rotation,
        ref bool success)
      {
        IntPtr* numPtr = stackalloc IntPtr[8];
        numPtr[0] = (IntPtr) &game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &owner;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &data;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &entry;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &position;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &rotation;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) ref success;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_Convert_Item_OnConsume.Server.NativeMethodInfoPtr_AddResultItem_Private_Static_Boolean_ServerGameManager_SelfServer_Entity_Script_Convert_Item_OnConsume_DataServer_Script_Convert_Item_OnConsume_Entry_float3_quaternion_byref_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Convert_Item_OnConsume.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Convert_Item_OnConsume.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Convert_Item_OnConsume.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Convert_Item_OnConsume>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Convert_Item_OnConsume.Server>.NativeClassPtr);
        Script_Convert_Item_OnConsume.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Convert_Item_OnConsume.Server>.NativeClassPtr, 100663391);
        Script_Convert_Item_OnConsume.Server.NativeMethodInfoPtr_OnGetPlacementResult_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Convert_Item_OnConsume.Server>.NativeClassPtr, 100663392);
        Script_Convert_Item_OnConsume.Server.NativeMethodInfoPtr_AddResultItem_Private_Static_Boolean_ServerGameManager_SelfServer_Entity_Script_Convert_Item_OnConsume_DataServer_Script_Convert_Item_OnConsume_Entry_float3_quaternion_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Convert_Item_OnConsume.Server>.NativeClassPtr, 100663393);
        Script_Convert_Item_OnConsume.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Convert_Item_OnConsume.Server>.NativeClassPtr, 100663394);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
