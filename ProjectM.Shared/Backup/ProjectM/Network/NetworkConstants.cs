// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkConstants
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public class NetworkConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_APP_IDENTIFIER;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_PORT;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_QUERY_PORT;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CONNECTED_USERS;
    private static readonly System.IntPtr NativeFieldInfoPtr_SERVER_TO_USER_NETBUFFER_SIZE_BYTES;
    private static readonly System.IntPtr NativeFieldInfoPtr_USER_TO_SERVER_NETBUFFER_SIZE_BYTES;
    private static readonly System.IntPtr NativeFieldInfoPtr_INCOMING_CLIENT_COMMANDS_CAPACITY;
    private static readonly System.IntPtr NativeFieldInfoPtr_NETWORKED_BUFFERS_INITIAL_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_NETWORKED_ALIVE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_BYTES_PER_PACKET;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_BITS_PER_PACKET;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PANIC_BITS;
    private static readonly System.IntPtr NativeFieldInfoPtr_PACKET_FILL_ATTEMPTS;
    private static readonly System.IntPtr NativeFieldInfoPtr_PACKET_FILL_ATTEMPT_IF_PACKET_SIZE_LESS_THAN;
    private static readonly System.IntPtr NativeFieldInfoPtr_PACKET_SAVED_FRAMES;
    private static readonly System.IntPtr NativeFieldInfoPtr_PACKET_MAX_ENTITIES;
    private static readonly System.IntPtr NativeFieldInfoPtr_PACKET_MAX_DESTROYED;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_BITS_PER_ENTITY;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_BYTES_PER_ENTITY;
    private static readonly System.IntPtr NativeFieldInfoPtr_SYNC_RADIUS;
    private static readonly System.IntPtr NativeFieldInfoPtr_SYNC_RADIUS_INNER;
    private static readonly System.IntPtr NativeFieldInfoPtr_SYNC_RADIUS_SQ;
    private static readonly System.IntPtr NativeFieldInfoPtr_SYNC_RADIUS_INNER_SQ;
    private static readonly System.IntPtr NativeFieldInfoPtr_BASE_PRIORITY;
    private static readonly System.IntPtr NativeFieldInfoPtr_SYNC_RATE;
    private static readonly System.IntPtr NativeFieldInfoPtr_LOOK_AT_ENTITY_PRIORITY_BOOST;
    private static readonly System.IntPtr NativeFieldInfoPtr_INNER_RADIUS_BOOST;
    private static readonly System.IntPtr NativeFieldInfoPtr_SERVER_TARGET_DELTA;
    private static readonly System.IntPtr NativeFieldInfoPtr_TIME_UNTIL_ONE_PANIC_PRIORITY;
    private static readonly System.IntPtr NativeFieldInfoPtr_ABILITY_MAX_LAG_COMPENSATION;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_COMMANDS_PER_PACKET;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SERVER_FRAMES_TO_ACK;
    private static readonly System.IntPtr NativeFieldInfoPtr_CLIENT_TO_SERVER_MAX_PACKET_SIZE_BYTES;
    private static readonly System.IntPtr NativeFieldInfoPtr_ROTATION_SPEED_BITS;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ROTATION_SPEED;
    private static readonly System.IntPtr NativeFieldInfoPtr_AIM_LENGTH_BITS;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_AIM_LENGTH;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkConstants()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkConstants.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkConstants()
    {
      Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr);
      NetworkConstants.NativeFieldInfoPtr_APP_IDENTIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (APP_IDENTIFIER));
      NetworkConstants.NativeFieldInfoPtr_DEFAULT_PORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (DEFAULT_PORT));
      NetworkConstants.NativeFieldInfoPtr_DEFAULT_QUERY_PORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (DEFAULT_QUERY_PORT));
      NetworkConstants.NativeFieldInfoPtr_MAX_CONNECTED_USERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (MAX_CONNECTED_USERS));
      NetworkConstants.NativeFieldInfoPtr_SERVER_TO_USER_NETBUFFER_SIZE_BYTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (SERVER_TO_USER_NETBUFFER_SIZE_BYTES));
      NetworkConstants.NativeFieldInfoPtr_USER_TO_SERVER_NETBUFFER_SIZE_BYTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (USER_TO_SERVER_NETBUFFER_SIZE_BYTES));
      NetworkConstants.NativeFieldInfoPtr_INCOMING_CLIENT_COMMANDS_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (INCOMING_CLIENT_COMMANDS_CAPACITY));
      NetworkConstants.NativeFieldInfoPtr_NETWORKED_BUFFERS_INITIAL_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (NETWORKED_BUFFERS_INITIAL_SIZE));
      NetworkConstants.NativeFieldInfoPtr_MAX_NETWORKED_ALIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (MAX_NETWORKED_ALIVE));
      NetworkConstants.NativeFieldInfoPtr_MAX_BYTES_PER_PACKET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (MAX_BYTES_PER_PACKET));
      NetworkConstants.NativeFieldInfoPtr_MAX_BITS_PER_PACKET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (MAX_BITS_PER_PACKET));
      NetworkConstants.NativeFieldInfoPtr_MAX_PANIC_BITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (MAX_PANIC_BITS));
      NetworkConstants.NativeFieldInfoPtr_PACKET_FILL_ATTEMPTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (PACKET_FILL_ATTEMPTS));
      NetworkConstants.NativeFieldInfoPtr_PACKET_FILL_ATTEMPT_IF_PACKET_SIZE_LESS_THAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (PACKET_FILL_ATTEMPT_IF_PACKET_SIZE_LESS_THAN));
      NetworkConstants.NativeFieldInfoPtr_PACKET_SAVED_FRAMES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (PACKET_SAVED_FRAMES));
      NetworkConstants.NativeFieldInfoPtr_PACKET_MAX_ENTITIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (PACKET_MAX_ENTITIES));
      NetworkConstants.NativeFieldInfoPtr_PACKET_MAX_DESTROYED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (PACKET_MAX_DESTROYED));
      NetworkConstants.NativeFieldInfoPtr_MAX_BITS_PER_ENTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (MAX_BITS_PER_ENTITY));
      NetworkConstants.NativeFieldInfoPtr_MAX_BYTES_PER_ENTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (MAX_BYTES_PER_ENTITY));
      NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (SYNC_RADIUS));
      NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS_INNER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (SYNC_RADIUS_INNER));
      NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (SYNC_RADIUS_SQ));
      NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS_INNER_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (SYNC_RADIUS_INNER_SQ));
      NetworkConstants.NativeFieldInfoPtr_BASE_PRIORITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (BASE_PRIORITY));
      NetworkConstants.NativeFieldInfoPtr_SYNC_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (SYNC_RATE));
      NetworkConstants.NativeFieldInfoPtr_LOOK_AT_ENTITY_PRIORITY_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (LOOK_AT_ENTITY_PRIORITY_BOOST));
      NetworkConstants.NativeFieldInfoPtr_INNER_RADIUS_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (INNER_RADIUS_BOOST));
      NetworkConstants.NativeFieldInfoPtr_SERVER_TARGET_DELTA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (SERVER_TARGET_DELTA));
      NetworkConstants.NativeFieldInfoPtr_TIME_UNTIL_ONE_PANIC_PRIORITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (TIME_UNTIL_ONE_PANIC_PRIORITY));
      NetworkConstants.NativeFieldInfoPtr_ABILITY_MAX_LAG_COMPENSATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (ABILITY_MAX_LAG_COMPENSATION));
      NetworkConstants.NativeFieldInfoPtr_MAX_COMMANDS_PER_PACKET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (MAX_COMMANDS_PER_PACKET));
      NetworkConstants.NativeFieldInfoPtr_MAX_SERVER_FRAMES_TO_ACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (MAX_SERVER_FRAMES_TO_ACK));
      NetworkConstants.NativeFieldInfoPtr_CLIENT_TO_SERVER_MAX_PACKET_SIZE_BYTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (CLIENT_TO_SERVER_MAX_PACKET_SIZE_BYTES));
      NetworkConstants.NativeFieldInfoPtr_ROTATION_SPEED_BITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (ROTATION_SPEED_BITS));
      NetworkConstants.NativeFieldInfoPtr_MAX_ROTATION_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (MAX_ROTATION_SPEED));
      NetworkConstants.NativeFieldInfoPtr_AIM_LENGTH_BITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (AIM_LENGTH_BITS));
      NetworkConstants.NativeFieldInfoPtr_MAX_AIM_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, nameof (MAX_AIM_LENGTH));
      NetworkConstants.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, 100669093);
    }

    public NetworkConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string APP_IDENTIFIER
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_APP_IDENTIFIER, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_APP_IDENTIFIER, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe int DEFAULT_PORT
    {
      get
      {
        int defaultPort;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_DEFAULT_PORT, (void*) &defaultPort);
        return defaultPort;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_DEFAULT_PORT, (void*) &value);
      }
    }

    public static unsafe int DEFAULT_QUERY_PORT
    {
      get
      {
        int defaultQueryPort;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_DEFAULT_QUERY_PORT, (void*) &defaultQueryPort);
        return defaultQueryPort;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_DEFAULT_QUERY_PORT, (void*) &value);
      }
    }

    public static unsafe ushort MAX_CONNECTED_USERS
    {
      get
      {
        ushort maxConnectedUsers;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_CONNECTED_USERS, (void*) &maxConnectedUsers);
        return maxConnectedUsers;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_CONNECTED_USERS, (void*) &value);
      }
    }

    public static unsafe int SERVER_TO_USER_NETBUFFER_SIZE_BYTES
    {
      get
      {
        int netbufferSizeBytes;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_SERVER_TO_USER_NETBUFFER_SIZE_BYTES, (void*) &netbufferSizeBytes);
        return netbufferSizeBytes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_SERVER_TO_USER_NETBUFFER_SIZE_BYTES, (void*) &value);
      }
    }

    public static unsafe int USER_TO_SERVER_NETBUFFER_SIZE_BYTES
    {
      get
      {
        int netbufferSizeBytes;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_USER_TO_SERVER_NETBUFFER_SIZE_BYTES, (void*) &netbufferSizeBytes);
        return netbufferSizeBytes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_USER_TO_SERVER_NETBUFFER_SIZE_BYTES, (void*) &value);
      }
    }

    public static unsafe int INCOMING_CLIENT_COMMANDS_CAPACITY
    {
      get
      {
        int commandsCapacity;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_INCOMING_CLIENT_COMMANDS_CAPACITY, (void*) &commandsCapacity);
        return commandsCapacity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_INCOMING_CLIENT_COMMANDS_CAPACITY, (void*) &value);
      }
    }

    public static unsafe int NETWORKED_BUFFERS_INITIAL_SIZE
    {
      get
      {
        int buffersInitialSize;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_NETWORKED_BUFFERS_INITIAL_SIZE, (void*) &buffersInitialSize);
        return buffersInitialSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_NETWORKED_BUFFERS_INITIAL_SIZE, (void*) &value);
      }
    }

    public static unsafe int MAX_NETWORKED_ALIVE
    {
      get
      {
        int maxNetworkedAlive;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_NETWORKED_ALIVE, (void*) &maxNetworkedAlive);
        return maxNetworkedAlive;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_NETWORKED_ALIVE, (void*) &value);
      }
    }

    public static unsafe int MAX_BYTES_PER_PACKET
    {
      get
      {
        int maxBytesPerPacket;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_BYTES_PER_PACKET, (void*) &maxBytesPerPacket);
        return maxBytesPerPacket;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_BYTES_PER_PACKET, (void*) &value);
      }
    }

    public static unsafe int MAX_BITS_PER_PACKET
    {
      get
      {
        int maxBitsPerPacket;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_BITS_PER_PACKET, (void*) &maxBitsPerPacket);
        return maxBitsPerPacket;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_BITS_PER_PACKET, (void*) &value);
      }
    }

    public static unsafe int MAX_PANIC_BITS
    {
      get
      {
        int maxPanicBits;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_PANIC_BITS, (void*) &maxPanicBits);
        return maxPanicBits;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_PANIC_BITS, (void*) &value);
      }
    }

    public static unsafe int PACKET_FILL_ATTEMPTS
    {
      get
      {
        int packetFillAttempts;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_PACKET_FILL_ATTEMPTS, (void*) &packetFillAttempts);
        return packetFillAttempts;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_PACKET_FILL_ATTEMPTS, (void*) &value);
      }
    }

    public static unsafe int PACKET_FILL_ATTEMPT_IF_PACKET_SIZE_LESS_THAN
    {
      get
      {
        int packetSizeLessThan;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_PACKET_FILL_ATTEMPT_IF_PACKET_SIZE_LESS_THAN, (void*) &packetSizeLessThan);
        return packetSizeLessThan;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_PACKET_FILL_ATTEMPT_IF_PACKET_SIZE_LESS_THAN, (void*) &value);
      }
    }

    public static unsafe int PACKET_SAVED_FRAMES
    {
      get
      {
        int packetSavedFrames;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_PACKET_SAVED_FRAMES, (void*) &packetSavedFrames);
        return packetSavedFrames;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_PACKET_SAVED_FRAMES, (void*) &value);
      }
    }

    public static unsafe int PACKET_MAX_ENTITIES
    {
      get
      {
        int packetMaxEntities;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_PACKET_MAX_ENTITIES, (void*) &packetMaxEntities);
        return packetMaxEntities;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_PACKET_MAX_ENTITIES, (void*) &value);
      }
    }

    public static unsafe int PACKET_MAX_DESTROYED
    {
      get
      {
        int packetMaxDestroyed;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_PACKET_MAX_DESTROYED, (void*) &packetMaxDestroyed);
        return packetMaxDestroyed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_PACKET_MAX_DESTROYED, (void*) &value);
      }
    }

    public static unsafe int MAX_BITS_PER_ENTITY
    {
      get
      {
        int maxBitsPerEntity;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_BITS_PER_ENTITY, (void*) &maxBitsPerEntity);
        return maxBitsPerEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_BITS_PER_ENTITY, (void*) &value);
      }
    }

    public static unsafe int MAX_BYTES_PER_ENTITY
    {
      get
      {
        int maxBytesPerEntity;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_BYTES_PER_ENTITY, (void*) &maxBytesPerEntity);
        return maxBytesPerEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_BYTES_PER_ENTITY, (void*) &value);
      }
    }

    public static unsafe float SYNC_RADIUS
    {
      get
      {
        float syncRadius;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS, (void*) &syncRadius);
        return syncRadius;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS, (void*) &value);
      }
    }

    public static unsafe float SYNC_RADIUS_INNER
    {
      get
      {
        float syncRadiusInner;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS_INNER, (void*) &syncRadiusInner);
        return syncRadiusInner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS_INNER, (void*) &value);
      }
    }

    public static unsafe float SYNC_RADIUS_SQ
    {
      get
      {
        float syncRadiusSq;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS_SQ, (void*) &syncRadiusSq);
        return syncRadiusSq;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS_SQ, (void*) &value);
      }
    }

    public static unsafe float SYNC_RADIUS_INNER_SQ
    {
      get
      {
        float syncRadiusInnerSq;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS_INNER_SQ, (void*) &syncRadiusInnerSq);
        return syncRadiusInnerSq;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_SYNC_RADIUS_INNER_SQ, (void*) &value);
      }
    }

    public static unsafe float BASE_PRIORITY
    {
      get
      {
        float basePriority;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_BASE_PRIORITY, (void*) &basePriority);
        return basePriority;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_BASE_PRIORITY, (void*) &value);
      }
    }

    public static unsafe float SYNC_RATE
    {
      get
      {
        float syncRate;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_SYNC_RATE, (void*) &syncRate);
        return syncRate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_SYNC_RATE, (void*) &value);
      }
    }

    public static unsafe float LOOK_AT_ENTITY_PRIORITY_BOOST
    {
      get
      {
        float entityPriorityBoost;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_LOOK_AT_ENTITY_PRIORITY_BOOST, (void*) &entityPriorityBoost);
        return entityPriorityBoost;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_LOOK_AT_ENTITY_PRIORITY_BOOST, (void*) &value);
      }
    }

    public static unsafe float INNER_RADIUS_BOOST
    {
      get
      {
        float innerRadiusBoost;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_INNER_RADIUS_BOOST, (void*) &innerRadiusBoost);
        return innerRadiusBoost;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_INNER_RADIUS_BOOST, (void*) &value);
      }
    }

    public static unsafe float SERVER_TARGET_DELTA
    {
      get
      {
        float serverTargetDelta;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_SERVER_TARGET_DELTA, (void*) &serverTargetDelta);
        return serverTargetDelta;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_SERVER_TARGET_DELTA, (void*) &value);
      }
    }

    public static unsafe float TIME_UNTIL_ONE_PANIC_PRIORITY
    {
      get
      {
        float onePanicPriority;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_TIME_UNTIL_ONE_PANIC_PRIORITY, (void*) &onePanicPriority);
        return onePanicPriority;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_TIME_UNTIL_ONE_PANIC_PRIORITY, (void*) &value);
      }
    }

    public static unsafe float ABILITY_MAX_LAG_COMPENSATION
    {
      get
      {
        float maxLagCompensation;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_ABILITY_MAX_LAG_COMPENSATION, (void*) &maxLagCompensation);
        return maxLagCompensation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_ABILITY_MAX_LAG_COMPENSATION, (void*) &value);
      }
    }

    public static unsafe int MAX_COMMANDS_PER_PACKET
    {
      get
      {
        int commandsPerPacket;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_COMMANDS_PER_PACKET, (void*) &commandsPerPacket);
        return commandsPerPacket;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_COMMANDS_PER_PACKET, (void*) &value);
      }
    }

    public static unsafe int MAX_SERVER_FRAMES_TO_ACK
    {
      get
      {
        int serverFramesToAck;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_SERVER_FRAMES_TO_ACK, (void*) &serverFramesToAck);
        return serverFramesToAck;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_SERVER_FRAMES_TO_ACK, (void*) &value);
      }
    }

    public static unsafe int CLIENT_TO_SERVER_MAX_PACKET_SIZE_BYTES
    {
      get
      {
        int maxPacketSizeBytes;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_CLIENT_TO_SERVER_MAX_PACKET_SIZE_BYTES, (void*) &maxPacketSizeBytes);
        return maxPacketSizeBytes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_CLIENT_TO_SERVER_MAX_PACKET_SIZE_BYTES, (void*) &value);
      }
    }

    public static unsafe int ROTATION_SPEED_BITS
    {
      get
      {
        int rotationSpeedBits;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_ROTATION_SPEED_BITS, (void*) &rotationSpeedBits);
        return rotationSpeedBits;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_ROTATION_SPEED_BITS, (void*) &value);
      }
    }

    public static unsafe float MAX_ROTATION_SPEED
    {
      get
      {
        float maxRotationSpeed;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_ROTATION_SPEED, (void*) &maxRotationSpeed);
        return maxRotationSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_ROTATION_SPEED, (void*) &value);
      }
    }

    public static unsafe int AIM_LENGTH_BITS
    {
      get
      {
        int aimLengthBits;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_AIM_LENGTH_BITS, (void*) &aimLengthBits);
        return aimLengthBits;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_AIM_LENGTH_BITS, (void*) &value);
      }
    }

    public static unsafe float MAX_AIM_LENGTH
    {
      get
      {
        float maxAimLength;
        IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_AIM_LENGTH, (void*) &maxAimLength);
        return maxAimLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_AIM_LENGTH, (void*) &value);
      }
    }
  }
}
