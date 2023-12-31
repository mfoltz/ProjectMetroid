// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyAfterDuration
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DestroyAfterDuration
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    [FieldOffset(0)]
    public float Duration;
    [FieldOffset(8)]
    public double EndTime;
    [FieldOffset(16)]
    public BlobAssetReference<ConditionBlob> Condition;

    static DestroyAfterDuration()
    {
      Il2CppClassPointerStore<DestroyAfterDuration>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DestroyAfterDuration));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyAfterDuration>.NativeClassPtr);
      DestroyAfterDuration.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDuration>.NativeClassPtr, nameof (Duration));
      DestroyAfterDuration.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDuration>.NativeClassPtr, nameof (EndTime));
      DestroyAfterDuration.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDuration>.NativeClassPtr, nameof (Condition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyAfterDuration>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
