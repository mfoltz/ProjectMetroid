﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantFactionPerkElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServantFactionPerkElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Perk;
    private static readonly System.IntPtr NativeFieldInfoPtr_Faction;
    [FieldOffset(0)]
    public PrefabGUID Perk;
    [FieldOffset(4)]
    public FactionEnum Faction;

    static ServantFactionPerkElement()
    {
      Il2CppClassPointerStore<ServantFactionPerkElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantFactionPerkElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantFactionPerkElement>.NativeClassPtr);
      ServantFactionPerkElement.NativeFieldInfoPtr_Perk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantFactionPerkElement>.NativeClassPtr, nameof (Perk));
      ServantFactionPerkElement.NativeFieldInfoPtr_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantFactionPerkElement>.NativeClassPtr, nameof (Faction));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantFactionPerkElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
