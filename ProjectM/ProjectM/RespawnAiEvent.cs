// Decompiled with JetBrains decompiler
// Type: ProjectM.RespawnAiEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RespawnAiEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    [FieldOffset(0)]
    public RespawnAiEventState State;
    [FieldOffset(4)]
    public float3 Position;
    [FieldOffset(16)]
    public int Range;

    static RespawnAiEvent()
    {
      Il2CppClassPointerStore<RespawnAiEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RespawnAiEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RespawnAiEvent>.NativeClassPtr);
      RespawnAiEvent.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnAiEvent>.NativeClassPtr, nameof (State));
      RespawnAiEvent.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnAiEvent>.NativeClassPtr, nameof (Position));
      RespawnAiEvent.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnAiEvent>.NativeClassPtr, nameof (Range));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RespawnAiEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
