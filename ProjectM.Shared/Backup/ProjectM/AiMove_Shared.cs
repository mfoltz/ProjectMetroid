// Decompiled with JetBrains decompiler
// Type: ProjectM.AiMove_Shared
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AiMove_Shared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Waypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasNextWaypoint;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetWaypoint_Public_Void_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetNextWaypoint_Public_Void_int2_0;
    [FieldOffset(0)]
    public int2 Waypoint;
    [FieldOffset(8)]
    public int2 NextWaypoint;
    [FieldOffset(16)]
    public bool HasWaypoint;
    [FieldOffset(17)]
    public bool HasNextWaypoint;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763474, RefRangeEnd = 763475, XrefRangeStart = 763474, XrefRangeEnd = 763474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetWaypoint(int2 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMove_Shared.NativeMethodInfoPtr_SetWaypoint_Public_Void_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetNextWaypoint(int2 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMove_Shared.NativeMethodInfoPtr_SetNextWaypoint_Public_Void_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AiMove_Shared()
    {
      Il2CppClassPointerStore<AiMove_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AiMove_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMove_Shared>.NativeClassPtr);
      AiMove_Shared.NativeFieldInfoPtr_Waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Shared>.NativeClassPtr, nameof (Waypoint));
      AiMove_Shared.NativeFieldInfoPtr_NextWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Shared>.NativeClassPtr, nameof (NextWaypoint));
      AiMove_Shared.NativeFieldInfoPtr_HasWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Shared>.NativeClassPtr, nameof (HasWaypoint));
      AiMove_Shared.NativeFieldInfoPtr_HasNextWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Shared>.NativeClassPtr, nameof (HasNextWaypoint));
      AiMove_Shared.NativeMethodInfoPtr_SetWaypoint_Public_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMove_Shared>.NativeClassPtr, 100667447);
      AiMove_Shared.NativeMethodInfoPtr_SetNextWaypoint_Public_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMove_Shared>.NativeClassPtr, 100667448);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMove_Shared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
