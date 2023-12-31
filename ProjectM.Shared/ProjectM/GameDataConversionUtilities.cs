// Decompiled with JetBrains decompiler
// Type: ProjectM.GameDataConversionUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class GameDataConversionUtilities : Il2CppSystem.Object
  {
    static GameDataConversionUtilities()
    {
      Il2CppClassPointerStore<GameDataConversionUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameDataConversionUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataConversionUtilities>.NativeClassPtr);
    }

    public GameDataConversionUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct NonConvertedPrefabTag
    {
      static NonConvertedPrefabTag()
      {
        Il2CppClassPointerStore<GameDataConversionUtilities.NonConvertedPrefabTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataConversionUtilities>.NativeClassPtr, nameof (NonConvertedPrefabTag));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataConversionUtilities.NonConvertedPrefabTag>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataConversionUtilities.NonConvertedPrefabTag>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
