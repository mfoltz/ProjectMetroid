// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncAlias_Rotation
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SyncAlias_Rotation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    [FieldOffset(0)]
    public quaternion Value;

    static SyncAlias_Rotation()
    {
      Il2CppClassPointerStore<SyncAlias_Rotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (SyncAlias_Rotation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncAlias_Rotation>.NativeClassPtr);
      SyncAlias_Rotation.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncAlias_Rotation>.NativeClassPtr, nameof (Value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncAlias_Rotation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
