// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SpawnDebugEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnDebugEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_Control;
    private static readonly System.IntPtr NativeFieldInfoPtr_Roam;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public float3 Position;
    [FieldOffset(16)]
    public quaternion Rotation;
    [FieldOffset(32)]
    public SpawnDebugEvent.TeamEnum Team;
    [FieldOffset(36)]
    public bool Control;
    [FieldOffset(37)]
    public bool Roam;
    [FieldOffset(40)]
    public int Level;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145255, XrefRangeEnd = 1145267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145279, RefRangeEnd = 1145280, XrefRangeStart = 1145267, XrefRangeEnd = 1145279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnDebugEvent()
    {
      Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (SpawnDebugEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr);
      SpawnDebugEvent.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr, nameof (PrefabGuid));
      SpawnDebugEvent.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr, nameof (Position));
      SpawnDebugEvent.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr, nameof (Rotation));
      SpawnDebugEvent.NativeFieldInfoPtr_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr, nameof (Team));
      SpawnDebugEvent.NativeFieldInfoPtr_Control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr, nameof (Control));
      SpawnDebugEvent.NativeFieldInfoPtr_Roam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr, nameof (Roam));
      SpawnDebugEvent.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr, nameof (Level));
      SpawnDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr, 100690685);
      SpawnDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr, 100690686);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnDebugEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum TeamEnum
    {
      Neutral,
      Ally,
      Enemy,
    }
  }
}
