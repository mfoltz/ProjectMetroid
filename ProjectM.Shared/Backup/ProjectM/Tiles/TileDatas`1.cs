// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileDatas`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public struct TileDatas<T> where T : unmanaged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Tiles;
    public BlobArray<TileDatas<T>.DataStruct> Tiles;

    static TileDatas()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<TileDatas<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", "TileDatas`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileDatas<T>>.NativeClassPtr);
      TileDatas<T>.NativeFieldInfoPtr_Tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatas<T>>.NativeClassPtr, nameof (Tiles));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileDatas<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public struct DataStruct
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Tile;
      private static readonly System.IntPtr NativeFieldInfoPtr_Data;
      public int2 Tile;
      public T Data;

      static DataStruct()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<TileDatas<T>.DataStruct>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileDatas<T>>.NativeClassPtr, nameof (DataStruct<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileDatas<T>.DataStruct>.NativeClassPtr);
        TileDatas<T>.DataStruct.NativeFieldInfoPtr_Tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatas<T>.DataStruct>.NativeClassPtr, nameof (Tile));
        TileDatas<T>.DataStruct.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatas<T>.DataStruct>.NativeClassPtr, nameof (Data));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileDatas<T>.DataStruct>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
