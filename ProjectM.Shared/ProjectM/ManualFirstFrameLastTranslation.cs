// Decompiled with JetBrains decompiler
// Type: ProjectM.ManualFirstFrameLastTranslation
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ManualFirstFrameLastTranslation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    [FieldOffset(0)]
    public Nullable_Unboxed<float3> Value;

    static ManualFirstFrameLastTranslation()
    {
      Il2CppClassPointerStore<ManualFirstFrameLastTranslation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ManualFirstFrameLastTranslation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualFirstFrameLastTranslation>.NativeClassPtr);
      ManualFirstFrameLastTranslation.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualFirstFrameLastTranslation>.NativeClassPtr, nameof (Value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManualFirstFrameLastTranslation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
