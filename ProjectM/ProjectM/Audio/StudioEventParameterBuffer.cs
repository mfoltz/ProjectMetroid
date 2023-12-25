// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StudioEventParameterBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StudioEventParameterBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    [FieldOffset(0)]
    public FixedString64 ParameterName;
    [FieldOffset(64)]
    public float Value;

    static StudioEventParameterBuffer()
    {
      Il2CppClassPointerStore<StudioEventParameterBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StudioEventParameterBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventParameterBuffer>.NativeClassPtr);
      StudioEventParameterBuffer.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventParameterBuffer>.NativeClassPtr, nameof (ParameterName));
      StudioEventParameterBuffer.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventParameterBuffer>.NativeClassPtr, nameof (Value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventParameterBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
