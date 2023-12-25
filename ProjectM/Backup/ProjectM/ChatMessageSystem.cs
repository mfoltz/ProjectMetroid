// Decompiled with JetBrains decompiler
// Type: ProjectM.ChatMessageSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class ChatMessageSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ChatMessageQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__UserQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllowGlobalChat;
    private static readonly System.IntPtr NativeFieldInfoPtr___ChatMessageJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ChatMessageJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForChatMessageJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002937, XrefRangeEnd = 1002959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChatMessageSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002959, XrefRangeEnd = 1003019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChatMessageSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChatMessageSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003019, XrefRangeEnd = 1003055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChatMessageSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003055, XrefRangeEnd = 1003074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForChatMessageJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.NativeMethodInfoPtr___GetEntityQuery_ForChatMessageJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1003078, RefRangeEnd = 1003079, XrefRangeStart = 1003074, XrefRangeEnd = 1003078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChatMessageSystem()
    {
      Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ChatMessageSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr);
      ChatMessageSystem.NativeFieldInfoPtr__ChatMessageQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, nameof (_ChatMessageQuery));
      ChatMessageSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      ChatMessageSystem.NativeFieldInfoPtr__UserQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, nameof (_UserQuery));
      ChatMessageSystem.NativeFieldInfoPtr__AllowGlobalChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, nameof (_AllowGlobalChat));
      ChatMessageSystem.NativeFieldInfoPtr___ChatMessageJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, "<>ChatMessageJob_entityQuery");
      ChatMessageSystem.NativeFieldInfoPtr___ChatMessageJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, "<>ChatMessageJob_profilerMarker");
      ChatMessageSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, 100677710);
      ChatMessageSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, 100677711);
      ChatMessageSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, 100677712);
      ChatMessageSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, 100677713);
      ChatMessageSystem.NativeMethodInfoPtr___GetEntityQuery_ForChatMessageJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, 100677714);
      ChatMessageSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, 100677715);
    }

    public ChatMessageSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _ChatMessageQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr__ChatMessageQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr__ChatMessageQuery)) = value;
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _UserQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr__UserQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr__UserQuery)) = value;
      }
    }

    public unsafe Nullable_Unboxed<bool> _AllowGlobalChat
    {
      get
      {
        return *(Nullable_Unboxed<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr__AllowGlobalChat));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr__AllowGlobalChat), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __ChatMessageJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr___ChatMessageJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr___ChatMessageJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ChatMessageJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr___ChatMessageJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.NativeFieldInfoPtr___ChatMessageJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ChatMessageSystem/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_allowGlobalChat;
      private static readonly System.IntPtr NativeFieldInfoPtr_users;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_timeUTC;
      private static readonly System.IntPtr NativeFieldInfoPtr_userEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ChatMessageEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity chatMessageEntity,
        [In] ref ChatMessageEvent chatMessage,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chatMessageEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref chatMessage;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ChatMessageEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr);
        ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
        ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (entityManager));
        ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_allowGlobalChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (allowGlobalChat));
        ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_users = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (users));
        ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (commandBuffer));
        ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_timeUTC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (timeUTC));
        ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_userEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (userEntities));
        ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        ChatMessageSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, 100677716);
        ChatMessageSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ChatMessageEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, 100677717);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass5_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass5_0>.NativeClassPtr, data));
      }

      public unsafe ChatMessageSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ChatMessageSystem) null : new ChatMessageSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe bool allowGlobalChat
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_allowGlobalChat));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_allowGlobalChat)) = value;
        }
      }

      public unsafe NativeArray<User> users
      {
        get
        {
          return *(NativeArray<User>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_users));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_users), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<User>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe long timeUTC
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_timeUTC));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_timeUTC)) = value;
        }
      }

      public unsafe NativeArray<Entity> userEntities
      {
        get
        {
          return *(NativeArray<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_userEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_userEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.ChatMessageSystem/ProjectM.<>c__DisplayClass_ChatMessageJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ChatMessageJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_allowGlobalChat;
      private static readonly System.IntPtr NativeFieldInfoPtr_users;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_timeUTC;
      private static readonly System.IntPtr NativeFieldInfoPtr_userEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_NetworkId_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_User_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Controller_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Team_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ChatMessageEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChatMessageSystem_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public bool allowGlobalChat;
      [FieldOffset(16)]
      public NativeArray<User> users;
      [FieldOffset(32)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(48)]
      public long timeUTC;
      [FieldOffset(56)]
      public NativeArray<Entity> userEntities;
      [FieldOffset(72)]
      public NativeHashMap<NetworkId, Entity> networkIdToEntityMap;
      [FieldOffset(88)]
      public ComponentDataFromEntity<NetworkId> _ComponentDataFromEntity_NetworkId_0;
      [FieldOffset(120)]
      public ComponentDataFromEntity<User> _ComponentDataFromEntity_User_1;
      [FieldOffset(152)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_2;
      [FieldOffset(184)]
      public ComponentDataFromEntity<Controller> _ComponentDataFromEntity_Controller_3;
      [FieldOffset(216)]
      public ComponentDataFromEntity<Team> _ComponentDataFromEntity_Team_4;
      [FieldOffset(248)]
      public ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(320)]
      public unsafe ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002842, XrefRangeEnd = 1002895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity chatMessageEntity,
        [In] ref ChatMessageEvent chatMessage,
        [In] ref FromCharacter fromCharacter)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chatMessageEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref chatMessage;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ChatMessageEvent_byref_FromCharacter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1002895, RefRangeEnd = 1002896, XrefRangeStart = 1002895, XrefRangeEnd = 1002895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ChatMessageSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1002896, RefRangeEnd = 1002897, XrefRangeStart = 1002896, XrefRangeEnd = 1002896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ChatMessageSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002897, XrefRangeEnd = 1002899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1002908, RefRangeEnd = 1002909, XrefRangeStart = 1002899, XrefRangeEnd = 1002908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1002926, RefRangeEnd = 1002927, XrefRangeStart = 1002909, XrefRangeEnd = 1002926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ChatMessageSystem componentSystem,
        ref ChatMessageSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChatMessageSystem_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002927, XrefRangeEnd = 1002931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002931, XrefRangeEnd = 1002937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ChatMessageJob()
      {
        Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatMessageSystem>.NativeClassPtr, "<>c__DisplayClass_ChatMessageJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr);
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (entityManager));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_allowGlobalChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (allowGlobalChat));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_users = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (users));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (commandBuffer));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_timeUTC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (timeUTC));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_userEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (userEntities));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr__ComponentDataFromEntity_NetworkId_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_NetworkId_0));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr__ComponentDataFromEntity_User_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_User_1));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_2));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr__ComponentDataFromEntity_Controller_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_Controller_3));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr__ComponentDataFromEntity_Team_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_Team_4));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (_runtimes));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ChatMessageEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, 100677718);
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, 100677719);
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, 100677720);
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, 100677721);
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, 100677722);
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChatMessageSystem_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, 100677723);
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, 100677724);
        ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, 100677725);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_chatMessageEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_chatMessage;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChatMessageSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_chatMessageEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ChatMessageEvent> forParameter_chatMessage;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1002758, RefRangeEnd = 1002759, XrefRangeStart = 1002751, XrefRangeEnd = 1002758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ChatMessageSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChatMessageSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1002766, RefRangeEnd = 1002767, XrefRangeStart = 1002759, XrefRangeEnd = 1002766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_chatMessageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_chatMessageEntity));
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_chatMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_chatMessage));
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChatMessageSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders>.NativeClassPtr, 100677726);
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders>.NativeClassPtr, 100677727);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_chatMessageEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_chatMessage;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_chatMessageEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ChatMessageEvent>.Runtime runtime_chatMessage;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.Runtime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_chatMessageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_chatMessageEntity));
            ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_chatMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_chatMessage));
            ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ChatMessageSystem/ProjectM.<>c__DisplayClass_ChatMessageJob/ProjectM.RunWithoutJobSystem_00003657$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, "RunWithoutJobSystem_00003657$PostfixBurstDelegate");
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677728);
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677729);
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677730);
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677731);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ChatMessageSystem/ProjectM.<>c__DisplayClass_ChatMessageJob/ProjectM.RunWithoutJobSystem_00003657$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002767, XrefRangeEnd = 1002781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002781, XrefRangeEnd = 1002799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002799, XrefRangeEnd = 1002814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1002841, RefRangeEnd = 1002842, XrefRangeStart = 1002814, XrefRangeEnd = 1002841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob>.NativeClassPtr, "RunWithoutJobSystem_00003657$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677732);
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677733);
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677734);
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677735);
          ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677737);
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
            IL2CPP.il2cpp_field_static_get_value(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChatMessageSystem.__c__DisplayClass_ChatMessageJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
