// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodQualityBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodQualityBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQualityBuffPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQualityBuffEntity;
    [FieldOffset(0)]
    public PrefabGUID BloodQualityBuffPrefabGuid;
    [FieldOffset(4)]
    public Entity BloodQualityBuffEntity;

    static BloodQualityBuff()
    {
      Il2CppClassPointerStore<BloodQualityBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BloodQualityBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodQualityBuff>.NativeClassPtr);
      BloodQualityBuff.NativeFieldInfoPtr_BloodQualityBuffPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityBuff>.NativeClassPtr, nameof (BloodQualityBuffPrefabGuid));
      BloodQualityBuff.NativeFieldInfoPtr_BloodQualityBuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityBuff>.NativeClassPtr, nameof (BloodQualityBuffEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodQualityBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
