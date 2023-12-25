// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ScrollingCombatText
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ScrollingCombatText
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr_Spawned;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SourceDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomXZDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomXZForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    [FieldOffset(0)]
    public bool Initialized;
    [FieldOffset(1)]
    public bool Spawned;
    [FieldOffset(4)]
    public float StartTime;
    [FieldOffset(8)]
    public float SpawnTime;
    [FieldOffset(12)]
    public float3 SourceDirection;
    [FieldOffset(24)]
    public float3 RandomXZDirection;
    [FieldOffset(36)]
    public float RandomXZForce;
    [FieldOffset(40)]
    public float Value;

    static ScrollingCombatText()
    {
      Il2CppClassPointerStore<ScrollingCombatText>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (ScrollingCombatText));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollingCombatText>.NativeClassPtr);
      ScrollingCombatText.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatText>.NativeClassPtr, nameof (Initialized));
      ScrollingCombatText.NativeFieldInfoPtr_Spawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatText>.NativeClassPtr, nameof (Spawned));
      ScrollingCombatText.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatText>.NativeClassPtr, nameof (StartTime));
      ScrollingCombatText.NativeFieldInfoPtr_SpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatText>.NativeClassPtr, nameof (SpawnTime));
      ScrollingCombatText.NativeFieldInfoPtr_SourceDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatText>.NativeClassPtr, nameof (SourceDirection));
      ScrollingCombatText.NativeFieldInfoPtr_RandomXZDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatText>.NativeClassPtr, nameof (RandomXZDirection));
      ScrollingCombatText.NativeFieldInfoPtr_RandomXZForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatText>.NativeClassPtr, nameof (RandomXZForce));
      ScrollingCombatText.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatText>.NativeClassPtr, nameof (Value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScrollingCombatText>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
