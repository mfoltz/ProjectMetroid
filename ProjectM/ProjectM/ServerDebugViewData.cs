// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerDebugViewData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServerDebugViewData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HasData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_Fps;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameTimeMs;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkStatsTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BytesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_BytesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_MessagesMaxBytesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_MessagesMaxBytesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_MessagesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_MessagesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_PacketsSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_PacketsReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiEnabledCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiHighPriorityCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_Static_ServerDebugViewData_ComponentSystemBase_0;
    [FieldOffset(0)]
    public bool HasData;
    [FieldOffset(4)]
    public int FrameCounter;
    [FieldOffset(8)]
    public int Fps;
    [FieldOffset(12)]
    public float FrameTimeMs;
    [FieldOffset(16)]
    public int EntitiesEnabled;
    [FieldOffset(20)]
    public int EntitiesDisabled;
    [FieldOffset(24)]
    public int NetworkedEntities;
    [FieldOffset(32)]
    public double NetworkStatsTime;
    [FieldOffset(40)]
    public int BytesSentPerSecond;
    [FieldOffset(44)]
    public int BytesReceivedPerSecond;
    [FieldOffset(48)]
    public int MessagesMaxBytesSentPerSecond;
    [FieldOffset(52)]
    public int MessagesMaxBytesReceivedPerSecond;
    [FieldOffset(56)]
    public int MessagesSentPerSecond;
    [FieldOffset(60)]
    public int MessagesReceivedPerSecond;
    [FieldOffset(64)]
    public int PacketsSentPerSecond;
    [FieldOffset(68)]
    public int PacketsReceivedPerSecond;
    [FieldOffset(72)]
    public int AiEnabledCount;
    [FieldOffset(76)]
    public int AiHighPriorityCount;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1050322, RefRangeEnd = 1050325, XrefRangeStart = 1050315, XrefRangeEnd = 1050322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ServerDebugViewData GetData(ComponentSystemBase systemBase)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerDebugViewData.NativeMethodInfoPtr_GetData_Public_Static_ServerDebugViewData_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerDebugViewData*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServerDebugViewData()
    {
      Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServerDebugViewData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr);
      ServerDebugViewData.NativeFieldInfoPtr_HasData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (HasData));
      ServerDebugViewData.NativeFieldInfoPtr_FrameCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (FrameCounter));
      ServerDebugViewData.NativeFieldInfoPtr_Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (Fps));
      ServerDebugViewData.NativeFieldInfoPtr_FrameTimeMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (FrameTimeMs));
      ServerDebugViewData.NativeFieldInfoPtr_EntitiesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (EntitiesEnabled));
      ServerDebugViewData.NativeFieldInfoPtr_EntitiesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (EntitiesDisabled));
      ServerDebugViewData.NativeFieldInfoPtr_NetworkedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (NetworkedEntities));
      ServerDebugViewData.NativeFieldInfoPtr_NetworkStatsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (NetworkStatsTime));
      ServerDebugViewData.NativeFieldInfoPtr_BytesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (BytesSentPerSecond));
      ServerDebugViewData.NativeFieldInfoPtr_BytesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (BytesReceivedPerSecond));
      ServerDebugViewData.NativeFieldInfoPtr_MessagesMaxBytesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (MessagesMaxBytesSentPerSecond));
      ServerDebugViewData.NativeFieldInfoPtr_MessagesMaxBytesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (MessagesMaxBytesReceivedPerSecond));
      ServerDebugViewData.NativeFieldInfoPtr_MessagesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (MessagesSentPerSecond));
      ServerDebugViewData.NativeFieldInfoPtr_MessagesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (MessagesReceivedPerSecond));
      ServerDebugViewData.NativeFieldInfoPtr_PacketsSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (PacketsSentPerSecond));
      ServerDebugViewData.NativeFieldInfoPtr_PacketsReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (PacketsReceivedPerSecond));
      ServerDebugViewData.NativeFieldInfoPtr_AiEnabledCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (AiEnabledCount));
      ServerDebugViewData.NativeFieldInfoPtr_AiHighPriorityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, nameof (AiHighPriorityCount));
      ServerDebugViewData.NativeMethodInfoPtr_GetData_Public_Static_ServerDebugViewData_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, 100682467);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerDebugViewData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
