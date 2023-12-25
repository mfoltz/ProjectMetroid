// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyWhenNoCharacterNearbyAfterDuration
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DestroyWhenNoCharacterNearbyAfterDuration
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveAtTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinimumRemoveDurationIfNearby;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomAdditionalDuration;
    [FieldOffset(0)]
    public double RemoveAtTime;
    [FieldOffset(8)]
    public float MinimumRemoveDurationIfNearby;
    [FieldOffset(12)]
    public float RandomAdditionalDuration;

    static DestroyWhenNoCharacterNearbyAfterDuration()
    {
      Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDuration>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DestroyWhenNoCharacterNearbyAfterDuration));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDuration>.NativeClassPtr);
      DestroyWhenNoCharacterNearbyAfterDuration.NativeFieldInfoPtr_RemoveAtTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDuration>.NativeClassPtr, nameof (RemoveAtTime));
      DestroyWhenNoCharacterNearbyAfterDuration.NativeFieldInfoPtr_MinimumRemoveDurationIfNearby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDuration>.NativeClassPtr, nameof (MinimumRemoveDurationIfNearby));
      DestroyWhenNoCharacterNearbyAfterDuration.NativeFieldInfoPtr_RandomAdditionalDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDuration>.NativeClassPtr, nameof (RandomAdditionalDuration));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDuration>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
