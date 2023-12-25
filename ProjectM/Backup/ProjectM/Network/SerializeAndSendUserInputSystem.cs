// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SerializeAndSendUserInputSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Network
{
  public class SerializeAndSendUserInputSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SerializeQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientBootstrapSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EmptyInputCommands;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr___IsInSafeSpace_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___IsInSafeSpace_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_63;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_64;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInSafeSpace_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForIsInSafeSpace_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151474, XrefRangeEnd = 1151504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializeAndSendUserInputSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151504, XrefRangeEnd = 1151510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializeAndSendUserInputSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151510, XrefRangeEnd = 1151585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializeAndSendUserInputSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1151611, RefRangeEnd = 1151612, XrefRangeStart = 1151585, XrefRangeEnd = 1151611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInSafeSpace()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.NativeMethodInfoPtr_IsInSafeSpace_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SerializeAndSendUserInputSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151612, XrefRangeEnd = 1151643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializeAndSendUserInputSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1151671, RefRangeEnd = 1151672, XrefRangeStart = 1151643, XrefRangeEnd = 1151671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForIsInSafeSpace_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.NativeMethodInfoPtr___GetEntityQuery_ForIsInSafeSpace_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1151676, RefRangeEnd = 1151677, XrefRangeStart = 1151672, XrefRangeEnd = 1151676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SerializeAndSendUserInputSystem()
    {
      Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (SerializeAndSendUserInputSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr);
      SerializeAndSendUserInputSystem.NativeFieldInfoPtr__SerializeQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, nameof (_SerializeQuery));
      SerializeAndSendUserInputSystem.NativeFieldInfoPtr__ClientBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, nameof (_ClientBootstrapSystem));
      SerializeAndSendUserInputSystem.NativeFieldInfoPtr__EmptyInputCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, nameof (_EmptyInputCommands));
      SerializeAndSendUserInputSystem.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, nameof (_WorldFrame));
      SerializeAndSendUserInputSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
      SerializeAndSendUserInputSystem.NativeFieldInfoPtr___IsInSafeSpace_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, "<>IsInSafeSpace_LambdaJob0_entityQuery");
      SerializeAndSendUserInputSystem.NativeFieldInfoPtr___IsInSafeSpace_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, "<>IsInSafeSpace_LambdaJob0_profilerMarker");
      SerializeAndSendUserInputSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_63 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalUser_63));
      SerializeAndSendUserInputSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ClientNetworkState_64));
      SerializeAndSendUserInputSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, 100691494);
      SerializeAndSendUserInputSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, 100691495);
      SerializeAndSendUserInputSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, 100691496);
      SerializeAndSendUserInputSystem.NativeMethodInfoPtr_IsInSafeSpace_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, 100691497);
      SerializeAndSendUserInputSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, 100691498);
      SerializeAndSendUserInputSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, 100691499);
      SerializeAndSendUserInputSystem.NativeMethodInfoPtr___GetEntityQuery_ForIsInSafeSpace_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, 100691500);
      SerializeAndSendUserInputSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, 100691501);
    }

    public SerializeAndSendUserInputSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _SerializeQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__SerializeQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__SerializeQuery)) = value;
      }
    }

    public unsafe ClientBootstrapSystem _ClientBootstrapSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__ClientBootstrapSystem));
        return pointer == System.IntPtr.Zero ? (ClientBootstrapSystem) null : new ClientBootstrapSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__ClientBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeArray<InputCommandBufferElement> _EmptyInputCommands
    {
      get
      {
        return *(NativeArray<InputCommandBufferElement>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__EmptyInputCommands));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__EmptyInputCommands), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InputCommandBufferElement>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap));
        return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __IsInSafeSpace_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr___IsInSafeSpace_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr___IsInSafeSpace_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __IsInSafeSpace_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr___IsInSafeSpace_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr___IsInSafeSpace_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalUser_63
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_63));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_63)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ClientNetworkState_64
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_64));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeAndSendUserInputSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_64)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SerializeUserInputJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientNetworkStateType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReceivedServerFrameType;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutgoingNetBufferType;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasLocalCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsInSafeSpace;
      private static readonly System.IntPtr NativeFieldInfoPtr_InputCommands;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar;
      private static readonly System.IntPtr NativeFieldInfoPtr_Interactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFrame;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SerializeUserInput_Public_Void_byref_ClientNetworkState_NativeArray_1_ReceivedServerFrame_NativeArray_1_Byte_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<ClientNetworkState> ClientNetworkStateType;
      [FieldOffset(32)]
      public BufferTypeHandle<ReceivedServerFrame> ReceivedServerFrameType;
      [FieldOffset(72)]
      public BufferTypeHandle<OutgoingNetBuffer> OutgoingNetBufferType;
      [FieldOffset(112)]
      public bool HasLocalCharacter;
      [FieldOffset(113)]
      public bool IsInSafeSpace;
      [FieldOffset(120)]
      public NativeArray<InputCommandBufferElement> InputCommands;
      [FieldOffset(136)]
      public AbilityBar_Client AbilityBar;
      [FieldOffset(312)]
      public Interactor Interactor;
      [FieldOffset(364)]
      public int CurrentFrame;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151260, XrefRangeEnd = 1151287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1151335, RefRangeEnd = 1151336, XrefRangeStart = 1151287, XrefRangeEnd = 1151335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SerializeUserInput(
        ref ClientNetworkState networkState,
        NativeArray<ReceivedServerFrame> receivedServerFrames,
        NativeArray<byte> dstBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref networkState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &receivedServerFrames;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dstBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeMethodInfoPtr_SerializeUserInput_Public_Void_byref_ClientNetworkState_NativeArray_1_ReceivedServerFrame_NativeArray_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SerializeUserInputJob()
      {
        Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, nameof (SerializeUserInputJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr);
        SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeFieldInfoPtr_ClientNetworkStateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, nameof (ClientNetworkStateType));
        SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeFieldInfoPtr_ReceivedServerFrameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, nameof (ReceivedServerFrameType));
        SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeFieldInfoPtr_OutgoingNetBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, nameof (OutgoingNetBufferType));
        SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeFieldInfoPtr_HasLocalCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, nameof (HasLocalCharacter));
        SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeFieldInfoPtr_IsInSafeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, nameof (IsInSafeSpace));
        SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeFieldInfoPtr_InputCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, nameof (InputCommands));
        SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeFieldInfoPtr_AbilityBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, nameof (AbilityBar));
        SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeFieldInfoPtr_Interactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, nameof (Interactor));
        SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeFieldInfoPtr_CurrentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, nameof (CurrentFrame));
        SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, 100691502);
        SerializeAndSendUserInputSystem.SerializeUserInputJob.NativeMethodInfoPtr_SerializeUserInput_Public_Void_byref_ClientNetworkState_NativeArray_1_ReceivedServerFrame_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, 100691503);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.SerializeUserInputJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Network.SerializeAndSendUserInputSystem/<>c__DisplayClass8_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass8_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_spatialLookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_getCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_isInSafeSpace;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__IsInSafeSpace_b__0_Internal_Void_byref_Translation_byref_Team_byref_BuffableFlagState_0;
      [FieldOffset(0)]
      public SpatialLookupParams spatialLookupParams;
      [FieldOffset(80)]
      public ComponentDataFromEntity<CastleFloor> getCastleFloor;
      [FieldOffset(112)]
      public ComponentDataFromEntity<TilePosition> getTilePosition;
      [FieldOffset(144)]
      public ComponentDataFromEntity<TileData> getTileData;
      [FieldOffset(176)]
      public EntityManager entityManager;
      [FieldOffset(184)]
      public bool isInSafeSpace;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _IsInSafeSpace_b__0(
        [In] ref Translation translation,
        [In] ref Team localCharacterTeam,
        [In] ref BuffableFlagState buffableFlagState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localCharacterTeam;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__IsInSafeSpace_b__0_Internal_Void_byref_Translation_byref_Team_byref_BuffableFlagState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass8_0>.NativeClassPtr);
        SerializeAndSendUserInputSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_spatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (spatialLookupParams));
        SerializeAndSendUserInputSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_getCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (getCastleFloor));
        SerializeAndSendUserInputSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_getTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (getTilePosition));
        SerializeAndSendUserInputSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_getTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (getTileData));
        SerializeAndSendUserInputSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (entityManager));
        SerializeAndSendUserInputSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_isInSafeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (isInSafeSpace));
        SerializeAndSendUserInputSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass8_0>.NativeClassPtr, 100691504);
        SerializeAndSendUserInputSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__IsInSafeSpace_b__0_Internal_Void_byref_Translation_byref_Team_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass8_0>.NativeClassPtr, 100691505);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass8_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Network.SerializeAndSendUserInputSystem/ProjectM.Network.<>c__DisplayClass_IsInSafeSpace_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_IsInSafeSpace_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_spatialLookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_getCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_isInSafeSpace;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Translation_byref_Team_byref_BuffableFlagState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializeAndSendUserInputSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public SpatialLookupParams spatialLookupParams;
      [FieldOffset(80)]
      public ComponentDataFromEntity<CastleFloor> getCastleFloor;
      [FieldOffset(112)]
      public ComponentDataFromEntity<TilePosition> getTilePosition;
      [FieldOffset(144)]
      public ComponentDataFromEntity<TileData> getTileData;
      [FieldOffset(176)]
      public EntityManager entityManager;
      [FieldOffset(184)]
      public bool isInSafeSpace;
      [FieldOffset(192)]
      public SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(288)]
      public unsafe SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151431, XrefRangeEnd = 1151445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref Translation translation,
        [In] ref Team localCharacterTeam,
        [In] ref BuffableFlagState buffableFlagState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localCharacterTeam;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Translation_byref_Team_byref_BuffableFlagState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1151445, RefRangeEnd = 1151446, XrefRangeStart = 1151445, XrefRangeEnd = 1151445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SerializeAndSendUserInputSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1151446, RefRangeEnd = 1151447, XrefRangeStart = 1151446, XrefRangeEnd = 1151446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SerializeAndSendUserInputSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151447, XrefRangeEnd = 1151449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1151460, RefRangeEnd = 1151461, XrefRangeStart = 1151449, XrefRangeEnd = 1151460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1151463, RefRangeEnd = 1151464, XrefRangeStart = 1151461, XrefRangeEnd = 1151463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SerializeAndSendUserInputSystem componentSystem,
        ref SerializeAndSendUserInputSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializeAndSendUserInputSystem_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151464, XrefRangeEnd = 1151468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151468, XrefRangeEnd = 1151474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_IsInSafeSpace_LambdaJob0()
      {
        Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializeAndSendUserInputSystem>.NativeClassPtr, "<>c__DisplayClass_IsInSafeSpace_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr);
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_spatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, nameof (spatialLookupParams));
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_getCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, nameof (getCastleFloor));
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_getTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, nameof (getTilePosition));
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_getTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, nameof (getTileData));
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_isInSafeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, nameof (isInSafeSpace));
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Translation_byref_Team_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, 100691506);
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, 100691507);
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, 100691508);
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, 100691509);
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, 100691510);
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializeAndSendUserInputSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, 100691511);
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, 100691512);
        SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, 100691513);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localCharacterTeam;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffableFlagState;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializeAndSendUserInputSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_localCharacterTeam;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<BuffableFlagState> forParameter_buffableFlagState;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1151345, RefRangeEnd = 1151346, XrefRangeStart = 1151336, XrefRangeEnd = 1151345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SerializeAndSendUserInputSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializeAndSendUserInputSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1151355, RefRangeEnd = 1151356, XrefRangeStart = 1151346, XrefRangeEnd = 1151355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localCharacterTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localCharacterTeam));
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffableFlagState));
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SerializeAndSendUserInputSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691514);
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691515);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localCharacterTeam;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffableFlagState;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_localCharacterTeam;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<BuffableFlagState>.Runtime runtime_buffableFlagState;

          static Runtimes()
          {
            Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localCharacterTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localCharacterTeam));
            SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffableFlagState));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Network.SerializeAndSendUserInputSystem/ProjectM.Network.<>c__DisplayClass_IsInSafeSpace_LambdaJob0/ProjectM.Network.RunWithoutJobSystem_000061D3$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000061D3$PostfixBurstDelegate");
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691516);
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691517);
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691518);
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691519);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Network.SerializeAndSendUserInputSystem/ProjectM.Network.<>c__DisplayClass_IsInSafeSpace_LambdaJob0/ProjectM.Network.RunWithoutJobSystem_000061D3$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151356, XrefRangeEnd = 1151370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151370, XrefRangeEnd = 1151388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151388, XrefRangeEnd = 1151403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1151430, RefRangeEnd = 1151431, XrefRangeStart = 1151403, XrefRangeEnd = 1151430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000061D3$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691520);
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691521);
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691522);
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691523);
          SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691525);
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
            IL2CPP.il2cpp_field_static_get_value(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SerializeAndSendUserInputSystem.__c__DisplayClass_IsInSafeSpace_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
