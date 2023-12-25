// Decompiled with JetBrains decompiler
// Type: ProjectM.DebugData
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DebugData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsClient;
    [FieldOffset(0)]
    public int CurrentFrame;
    [FieldOffset(4)]
    public bool IsClient;

    static DebugData()
    {
      Il2CppClassPointerStore<DebugData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (DebugData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugData>.NativeClassPtr);
      DebugData.NativeFieldInfoPtr_CurrentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugData>.NativeClassPtr, nameof (CurrentFrame));
      DebugData.NativeFieldInfoPtr_IsClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugData>.NativeClassPtr, nameof (IsClient));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
