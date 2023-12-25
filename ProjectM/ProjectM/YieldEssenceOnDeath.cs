// Decompiled with JetBrains decompiler
// Type: ProjectM.YieldEssenceOnDeath
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct YieldEssenceOnDeath
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EssenceSplitAreaRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_EssenceGain;
    private static readonly System.IntPtr NativeFieldInfoPtr_EssenceItemType;
    [FieldOffset(0)]
    public float EssenceSplitAreaRadius;
    [FieldOffset(4)]
    public int EssenceGain;
    [FieldOffset(8)]
    public PrefabGUID EssenceItemType;

    static YieldEssenceOnDeath()
    {
      Il2CppClassPointerStore<YieldEssenceOnDeath>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (YieldEssenceOnDeath));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldEssenceOnDeath>.NativeClassPtr);
      YieldEssenceOnDeath.NativeFieldInfoPtr_EssenceSplitAreaRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldEssenceOnDeath>.NativeClassPtr, nameof (EssenceSplitAreaRadius));
      YieldEssenceOnDeath.NativeFieldInfoPtr_EssenceGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldEssenceOnDeath>.NativeClassPtr, nameof (EssenceGain));
      YieldEssenceOnDeath.NativeFieldInfoPtr_EssenceItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldEssenceOnDeath>.NativeClassPtr, nameof (EssenceItemType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YieldEssenceOnDeath>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
