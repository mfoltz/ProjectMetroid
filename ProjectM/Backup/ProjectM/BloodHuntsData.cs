// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodHuntsData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodHuntsData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrackPrefabGuid;
    [FieldOffset(0)]
    public SequenceGUID UnlockGuid;
    [FieldOffset(4)]
    public PrefabGUID TrackPrefabGuid;

    static BloodHuntsData()
    {
      Il2CppClassPointerStore<BloodHuntsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BloodHuntsData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodHuntsData>.NativeClassPtr);
      BloodHuntsData.NativeFieldInfoPtr_UnlockGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodHuntsData>.NativeClassPtr, nameof (UnlockGuid));
      BloodHuntsData.NativeFieldInfoPtr_TrackPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodHuntsData>.NativeClassPtr, nameof (TrackPrefabGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodHuntsData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
