// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyAfterDuration_ActiveUserCheck
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DestroyAfterDuration_ActiveUserCheck
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurationModifier;
    [FieldOffset(0)]
    public float Range;
    [FieldOffset(4)]
    public float DurationModifier;

    static DestroyAfterDuration_ActiveUserCheck()
    {
      Il2CppClassPointerStore<DestroyAfterDuration_ActiveUserCheck>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DestroyAfterDuration_ActiveUserCheck));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyAfterDuration_ActiveUserCheck>.NativeClassPtr);
      DestroyAfterDuration_ActiveUserCheck.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDuration_ActiveUserCheck>.NativeClassPtr, nameof (Range));
      DestroyAfterDuration_ActiveUserCheck.NativeFieldInfoPtr_DurationModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDuration_ActiveUserCheck>.NativeClassPtr, nameof (DurationModifier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyAfterDuration_ActiveUserCheck>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
