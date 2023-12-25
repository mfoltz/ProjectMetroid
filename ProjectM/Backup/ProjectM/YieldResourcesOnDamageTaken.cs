// Decompiled with JetBrains decompiler
// Type: ProjectM.YieldResourcesOnDamageTaken
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct YieldResourcesOnDamageTaken
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
    private static readonly System.IntPtr NativeFieldInfoPtr_AmountTaken;
    [FieldOffset(0)]
    public PrefabGUID ItemType;
    [FieldOffset(4)]
    public int Amount;
    [FieldOffset(8)]
    public int AmountTaken;

    static YieldResourcesOnDamageTaken()
    {
      Il2CppClassPointerStore<YieldResourcesOnDamageTaken>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (YieldResourcesOnDamageTaken));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldResourcesOnDamageTaken>.NativeClassPtr);
      YieldResourcesOnDamageTaken.NativeFieldInfoPtr_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldResourcesOnDamageTaken>.NativeClassPtr, nameof (ItemType));
      YieldResourcesOnDamageTaken.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldResourcesOnDamageTaken>.NativeClassPtr, nameof (Amount));
      YieldResourcesOnDamageTaken.NativeFieldInfoPtr_AmountTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldResourcesOnDamageTaken>.NativeClassPtr, nameof (AmountTaken));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YieldResourcesOnDamageTaken>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
