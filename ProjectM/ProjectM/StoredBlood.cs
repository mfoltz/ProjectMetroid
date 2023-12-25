// Decompiled with JetBrains decompiler
// Type: ProjectM.StoredBlood
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StoredBlood
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodType;
    [FieldOffset(0)]
    public float BloodQuality;
    [FieldOffset(4)]
    public PrefabGUID BloodType;

    static StoredBlood()
    {
      Il2CppClassPointerStore<StoredBlood>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StoredBlood));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredBlood>.NativeClassPtr);
      StoredBlood.NativeFieldInfoPtr_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredBlood>.NativeClassPtr, nameof (BloodQuality));
      StoredBlood.NativeFieldInfoPtr_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredBlood>.NativeClassPtr, nameof (BloodType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StoredBlood>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
