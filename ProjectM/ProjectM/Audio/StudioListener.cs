// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StudioListener
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StudioListener
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EarPosition;
    [FieldOffset(0)]
    public float3 EarPosition;

    static StudioListener()
    {
      Il2CppClassPointerStore<StudioListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StudioListener));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioListener>.NativeClassPtr);
      StudioListener.NativeFieldInfoPtr_EarPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioListener>.NativeClassPtr, nameof (EarPosition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioListener>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
