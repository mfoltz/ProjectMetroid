// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.DisconnectedTimer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DisconnectedTimer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsInSafeSpace;
    [FieldOffset(0)]
    public float Value;
    [FieldOffset(4)]
    public bool IsDisabled;
    [FieldOffset(5)]
    public bool IsInSafeSpace;

    static DisconnectedTimer()
    {
      Il2CppClassPointerStore<DisconnectedTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (DisconnectedTimer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisconnectedTimer>.NativeClassPtr);
      DisconnectedTimer.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisconnectedTimer>.NativeClassPtr, nameof (Value));
      DisconnectedTimer.NativeFieldInfoPtr_IsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisconnectedTimer>.NativeClassPtr, nameof (IsDisabled));
      DisconnectedTimer.NativeFieldInfoPtr_IsInSafeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisconnectedTimer>.NativeClassPtr, nameof (IsInSafeSpace));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisconnectedTimer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
