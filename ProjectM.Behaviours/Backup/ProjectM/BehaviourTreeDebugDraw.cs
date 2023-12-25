// Decompiled with JetBrains decompiler
// Type: ProjectM.BehaviourTreeDebugDraw
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeDebugDraw
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Pos0;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawPos0;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawPos1;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawPos2;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawPos3;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawPos4;
    [FieldOffset(0)]
    public float3 Pos0;
    [FieldOffset(12)]
    public bool DrawPos0;
    [FieldOffset(13)]
    public bool DrawPos1;
    [FieldOffset(14)]
    public bool DrawPos2;
    [FieldOffset(15)]
    public bool DrawPos3;
    [FieldOffset(16)]
    public bool DrawPos4;

    static BehaviourTreeDebugDraw()
    {
      Il2CppClassPointerStore<BehaviourTreeDebugDraw>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (BehaviourTreeDebugDraw));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeDebugDraw>.NativeClassPtr);
      BehaviourTreeDebugDraw.NativeFieldInfoPtr_Pos0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugDraw>.NativeClassPtr, nameof (Pos0));
      BehaviourTreeDebugDraw.NativeFieldInfoPtr_DrawPos0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugDraw>.NativeClassPtr, nameof (DrawPos0));
      BehaviourTreeDebugDraw.NativeFieldInfoPtr_DrawPos1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugDraw>.NativeClassPtr, nameof (DrawPos1));
      BehaviourTreeDebugDraw.NativeFieldInfoPtr_DrawPos2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugDraw>.NativeClassPtr, nameof (DrawPos2));
      BehaviourTreeDebugDraw.NativeFieldInfoPtr_DrawPos3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugDraw>.NativeClassPtr, nameof (DrawPos3));
      BehaviourTreeDebugDraw.NativeFieldInfoPtr_DrawPos4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugDraw>.NativeClassPtr, nameof (DrawPos4));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeDebugDraw>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
